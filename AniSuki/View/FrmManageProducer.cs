﻿using System;
using System.Linq;
using System.Windows.Forms;
using AniSuki.Model;
using AniSuki.Util;
using AniSuki.View.Control;
using AniSuki.View.Templete;
using Neetsonic.Control;
using Neetsonic.Tool;
using TextBox = Neetsonic.Control.TextBox;

namespace AniSuki.View
{
    public partial class FrmManageProducer : FrmBase
    {
        public FrmManageProducer()
        {
            InitializeComponent();
            InitControl();
            BindEvent();
        }

        private ProducerList _producers;
        private Producer _currProducer = new Producer();
        private Producer _selectedProducer;

        private ProducerList Producers
        {
            get => _producers;
            set
            {
                _producers = value;
                OnProducersChanged();
            }
        }
        private Producer CurrProducer
        {
            get => _currProducer;
            set
            {
                _currProducer = value;
                OnCurrProducerChanged();
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

        private void OnSelectedProducerChanged()
        {
            CurrProducer = null == SelectedProducer ? new Producer() : SelectedProducer.ShollowClone();
        }
        private void OnCurrProducerChanged()
        {
            txtName.Text = CurrProducer?.Name;
            txtWebsite.Text = CurrProducer?.Website;
            btnNew.Enabled = !string.IsNullOrWhiteSpace(CurrProducer?.Name);
            btnUpdate.Enabled = btnNew.Enabled && null != SelectedProducer;
        }
        private void OnProducersChanged()
        {
            dgvProducer.DataList = Producers;
        }

        private void InitControl()
        {
            dgvProducer.SetColumns(new[]
            {
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"ID",
                    HeaderText = @"编号",
                    Visible = false
                },
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"Name",
                    HeaderText = @"公司名称"
                },
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"Website",
                    HeaderText = @"官方网站",
                    Type = typeof(DataGridViewLinkColumn),
                    SortMode = DataGridViewColumnSortMode.NotSortable
                }
            });
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
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
            dgvProducer.SelectionChanged += (sender, args) =>
            {
                SelectedProducer = ((ProducerDataGridView)sender).SelectedItem;
            };
        }

        private void FrmManageProducer_Load(object sender, EventArgs e)
        {
            Producers = new ProducerList(DataAccess.GetProducer().ToList());
        }
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
        private void CmsDgvProducer_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = dgvProducer.SelectedItem == null;
        }
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
    }
}