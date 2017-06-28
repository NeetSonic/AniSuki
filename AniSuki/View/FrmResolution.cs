using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AniSuki.Model;
using AniSuki.Util;
using AniSuki.View.Control;
using AniSuki.View.Templete;
using Neetsonic.Tool;

namespace AniSuki.View
{
    public partial class FrmResolution : FrmBase
    {
        public FrmResolution()
        {
            InitializeComponent();
            InitControl();
            BindEvent();
        }

        private ResolutionList _resolutions;
        private Resolution _currResolution = new Resolution();
        private Resolution _selectedResolution;

        private ResolutionList Resolutions
        {
            get => _resolutions;
            set
            {
                _resolutions = value;
                OnResolutionsChanged();
            }
        }
        private Resolution CurrResolution
        {
            get => _currResolution;
            set
            {
                _currResolution = value;
                OnCurrResolutionChanged();
            }
        }
        private Resolution SelectedResolution
        {
            get => _selectedResolution;
            set
            {
                _selectedResolution = value;
                OnSelectedResolutionChanged();
            }
        }

        private void OnSelectedResolutionChanged()
        {
            CurrResolution = null == SelectedResolution ? new Resolution() : SelectedResolution.ShollowClone();
        }
        private void OnCurrResolutionChanged()
        {
            numWidth.Value = CurrResolution?.Width ?? 0.0m;
            numHeight.Value = CurrResolution?.Height ?? 0.0m;
            ;
            btnNew.Enabled = CurrResolution.Width > 0 && CurrResolution.Height > 0;
            btnUpdate.Enabled = btnNew.Enabled && null != SelectedResolution;
        }
        private void OnResolutionsChanged()
        {
            dgvResolution.DataList = Resolutions;
        }

        private void InitControl()
        {
            dgvResolution.SetColumns();
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void BindEvent()
        {
            numWidth.ValueChanged += (sender, args) =>
            {
                CurrResolution.Width = Convert.ToInt16(((NumericUpDown)sender).Value);
                OnCurrResolutionChanged();
            };
            numHeight.ValueChanged += (sender, args) =>
            {
                CurrResolution.Height = Convert.ToInt16(((NumericUpDown)sender).Value);
                OnCurrResolutionChanged();
            };
            dgvResolution.SelectionChanged += (sender, args) => SelectedResolution = ((ResolutionDataGridView)sender).SelectedItem;
        }

        private void FrmResolution_Load(object sender, EventArgs e)
        {
            Resolutions = new ResolutionList(DataAccess.GetResolution().ToList());
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                CurrResolution.ID = DataAccess.NewResolution(CurrResolution);
                dgvResolution.AddItem(CurrResolution.ShollowClone());
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
                DataAccess.UpdateResolution(CurrResolution);
                dgvResolution.UpdateCurrSelectedItem((ref Resolution res) =>
                {
                    res.Width = CurrResolution.Width;
                    res.Height = CurrResolution.Height;
                });
            }
            catch(Exception ex)
            {
                MessageBoxEx.Error(ex.Message);
            }
        }
        private void CmsDgvResolution_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = dgvResolution.SelectedItem == null;
        }
        private void MenuDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(DialogResult.OK != MessageBoxEx.Confirm($"确定要删除 \"{CurrResolution.ResolutionString}\" 吗？")) return;
                DataAccess.DeleteResolution(CurrResolution);
                dgvResolution.RemoveCurrSelectedItem();
            }
            catch(Exception ex)
            {
                MessageBoxEx.Error(ex.Message);
            }
        }
    }
}