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
    public partial class FrmProducer : FrmBase
    {
        public FrmProducer()
        {
            InitializeComponent();
            InitControl();
            BindEvent();
        }

        private Producer _currProducer = new Producer();
        private ProducerList _producers;
        private Producer _selectedProducer;

        private Producer CurrProducer
        {
            get => _currProducer;
            set
            {
                _currProducer = value;
                OnCurrProducerChanged();
            }
        }
        private ProducerList Producers
        {
            get => _producers;
            set
            {
                _producers = value;
                OnProducersChanged();
            }
        }
        private Producer SelectedProducer
        {
            get => _selectedProducer;
            set
            {
                _selectedProducer = value;
                OnSelectedProducerChanged();
            }
        }

        private void BindEvent()
        {
            txtName.TextChanged += (sender, args) =>
            {
                CurrProducer.Name = ((TextBox)sender).Text;
                OnCurrProducerChanged();
            };
            txtWebsite.TextChanged += (sender, args) =>
            {
                CurrProducer.Website = ((TextBox)sender).Text;
                OnCurrProducerChanged();
            };
            dgvProducer.SelectionChanged += (sender, args) => SelectedProducer = ((ProducerDataGridView)sender).SelectedItem;
        }
        private void InitControl()
        {
            dgvProducer.SetColumns();
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void OnCurrProducerChanged()
        {
            txtName.Text = CurrProducer?.Name;
            txtWebsite.Text = CurrProducer?.Website;
            btnNew.Enabled = !string.IsNullOrWhiteSpace(CurrProducer?.Name);
            btnUpdate.Enabled = btnNew.Enabled && null != SelectedProducer;
        }
        private void OnProducersChanged() => dgvProducer.DataList = Producers;
        private void OnSelectedProducerChanged() => CurrProducer = null == SelectedProducer ? new Producer() : SelectedProducer.ShollowClone();

        private void MenuDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(DialogResult.OK != MessageBoxEx.Confirm($"确定要删除 \"{CurrProducer.Name}\" 吗？")) return;
                DataAccess.DeleteProducer(CurrProducer);
                dgvProducer.RemoveCurrSelectedItem();
            }
            catch(Exception ex)
            {
                MessageBoxEx.Error(ex.Message);
            }
        }
        private void FrmProducer_Load(object sender, EventArgs e) => Producers = new ProducerList(DataAccess.GetProducer().ToList());
        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                CurrProducer.ID = DataAccess.NewProducer(CurrProducer);
                dgvProducer.AddItem(CurrProducer.ShollowClone());
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
                DataAccess.UpdateProducer(CurrProducer);
                dgvProducer.UpdateCurrSelectedItem((ref Producer pro) =>
                {
                    pro.Name = CurrProducer.Name;
                    pro.Website = CurrProducer.Website;
                });
            }
            catch(Exception ex)
            {
                MessageBoxEx.Error(ex.Message);
            }
        }
        private void CmsDgvProducer_Opening(object sender, CancelEventArgs e) => e.Cancel = dgvProducer.SelectedItem == null;
    }
}