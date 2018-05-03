using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AniSuki.Model;
using AniSuki.Util;
using AniSuki.View.Control;
using AniSuki.View.Templete;
using Neetsonic.Tool;
using Neetsonic.Tool.Extensions;
using TextBox = Neetsonic.Control.TextBox;

namespace AniSuki.View
{
    public partial class FrmVoiceActor : FrmBase
    {
        public FrmVoiceActor()
        {
            InitializeComponent();
            InitControl();
            BindEvent();
        }

        private VoiceActorList _tags;
        private VoiceActor _currVoiceActor = new VoiceActor();
        private VoiceActor _selectedVoiceActor;

        private VoiceActorList VoiceActors
        {
            get => _tags;
            set
            {
                _tags = value;
                OnVoiceActorsChanged();
            }
        }
        private VoiceActor CurrVoiceActor
        {
            get => _currVoiceActor;
            set
            {
                _currVoiceActor = value;
                OnCurrVoiceActorChanged();
            }
        }
        private VoiceActor SelectedVoiceActor
        {
            get => _selectedVoiceActor;
            set
            {
                _selectedVoiceActor = value;
                OnSelectedVoiceActorChanged();
            }
        }

        private void OnSelectedVoiceActorChanged() => CurrVoiceActor = null == SelectedVoiceActor ? new VoiceActor() : SelectedVoiceActor.ShollowClone();
        private void OnCurrVoiceActorChanged()
        {
            txtName.Text = CurrVoiceActor?.Name;
            btnNew.Enabled = !string.IsNullOrWhiteSpace(CurrVoiceActor?.Name);
            btnUpdate.Enabled = btnNew.Enabled && null != SelectedVoiceActor;
        }
        private void OnVoiceActorsChanged() => dgvVoiceActor.DataList = VoiceActors;

        private void BindEvent()
        {
            txtName.TextChanged += (sender, args) =>
            {
                CurrVoiceActor.Name = ((TextBox)sender).Text;
                OnCurrVoiceActorChanged();
            };
            dgvVoiceActor.SelectionChanged += (sender, args) => SelectedVoiceActor = ((VoiceActorDataGridView)sender).SelectedItem;
        }
        private void InitControl()
        {
            dgvVoiceActor.SetColumns();
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                CurrVoiceActor.ID = DataAccess.NewVoiceActor(CurrVoiceActor);
                dgvVoiceActor.AddItem(CurrVoiceActor.ShollowClone());
            }
            catch(Exception ex)
            {
                MessageBoxEx.Error(ex.Message);
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess.UpdateVoiceActor(CurrVoiceActor);
                dgvVoiceActor.UpdateCurrSelectedItem((ref VoiceActor pro) =>
                {
                    pro.Name = CurrVoiceActor.Name;
                });
            }
            catch(Exception ex)
            {
                MessageBoxEx.Error(ex.Message);
            }
        }
        private void MenuDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(DialogResult.OK != MessageBoxEx.Confirm($"确定要删除 \"{CurrVoiceActor.Name}\" 吗？")) return;
                DataAccess.DeleteVoiceActor(CurrVoiceActor);
                dgvVoiceActor.RemoveCurrSelectedItem();
            }
            catch(Exception ex)
            {
                MessageBoxEx.Error(ex.Message);
            }
        }
        private void CmsDgvVoiceActor_Opening(object sender, CancelEventArgs e) => e.Cancel = dgvVoiceActor.SelectedItem == null;
        private void FrmVoiceActor_Load(object sender, EventArgs e) => VoiceActors = new VoiceActorList(DataAccess.GetVoiceActor().ToList());
    }
}