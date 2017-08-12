using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AniSuki.Model;
using AniSuki.Util;
using AniSuki.View.Templete;

namespace AniSuki.View.Functional
{
    public partial class FrmRecast : FrmBase
    {
        private readonly IEnumerable<Cast> _casts;

        public FrmRecast(IEnumerable<Cast> casts)
        {
            _casts = casts;
            InitializeComponent();
            InitControls();
            BindEvents();
        }

        private Cast CurrCast { get; } = new Cast();
        public IEnumerable<Cast> NewCasts => (dgvCast.DataList as CastList).AsEnumerable();

        private void OnCurrCastChanged() => btnNewCast.Enabled = !string.IsNullOrWhiteSpace(CurrCast?.CharaName) && CurrCast?.VoiceActorID != 0;
        private void BindEvents()
        {
            txtCharaName.TextChanged += (sender, args) =>
            {
                CurrCast.CharaName = ((TextBox)sender).Text;
                OnCurrCastChanged();
            };
            cmbVoiceActor.SelectedIndexChanged += (sender, args) =>
            {
                VoiceActor voiceActor = (VoiceActor)cmbVoiceActor.SelectedItem;
                if(null == voiceActor)
                {
                    CurrCast.VoiceActorID = 0;
                    CurrCast.VoiceActor = null;
                }
                else
                {
                    CurrCast.VoiceActorID = voiceActor.ID;
                    CurrCast.VoiceActor = voiceActor.Name;
                }
                OnCurrCastChanged();
            };
        }
        private void InitControls()
        {
            dgvCast.SetColumns();
            btnNewCast.Enabled = false;
        }
        private void LoadVoiceActors()
        {
            cmbVoiceActor.DataSource = DataAccess.GetVoiceActor().ToList();
            cmbVoiceActor.DisplayMember = @"Name";
            cmbVoiceActor.ValueMember = @"ID";
            cmbVoiceActor.SelectedItem = null;
        }
        private void LoadCast()=>dgvCast.DataList = new CastList(_casts.ToList());
        

        private void BtnManageVoiceActor_Click(object sender, EventArgs e)
        {
            new FrmVoiceActor().ShowDialog();
            LoadVoiceActors();
        }
        private void BtnNewCast_Click(object sender, EventArgs e)
        {
            dgvCast.AddItem(CurrCast.ShollowClone());
            txtCharaName.Text = null;
        }
        private void BtnOK_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;
        private void MenuDgvCast_Opening(object sender, CancelEventArgs e) => e.Cancel = dgvCast.SelectedItem == null;
        private void MenuDeleteCast_Click(object sender, EventArgs e) => dgvCast.RemoveCurrSelectedItem();
        private void FrmRecast_Load(object sender, EventArgs e)
        {
            LoadVoiceActors();
            LoadCast();
        }
    }
}