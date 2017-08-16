using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AniSuki.Model;
using AniSuki.Util;
using AniSuki.View.Control;
using AniSuki.View.Templete;
using Neetsonic.Tool;
using TextBox = Neetsonic.Control.TextBox;

namespace AniSuki.View
{
    public partial class FrmTag : FrmBase
    {
        public FrmTag()
        {
            InitializeComponent();
            InitControl();
            BindEvent();
        }

        private TagList _tags;
        private Tag _currTag = new Tag();
        private Tag _selectedTag;

        private TagList Tags
        {
            get => _tags;
            set
            {
                _tags = value;
                OnTagsChanged();
            }
        }
        private Tag CurrTag
        {
            get => _currTag;
            set
            {
                _currTag = value;
                OnCurrTagChanged();
            }
        }
        private Tag SelectedTag
        {
            get => _selectedTag;
            set
            {
                _selectedTag = value;
                OnSelectedTagChanged();
            }
        }

        private void OnSelectedTagChanged() => CurrTag = null == SelectedTag ? new Tag() : SelectedTag.ShollowClone();
        private void OnCurrTagChanged()
        {
            txtName.Text = CurrTag?.Name;
            btnNew.Enabled = !string.IsNullOrWhiteSpace(CurrTag?.Name);
            btnUpdate.Enabled = btnNew.Enabled && null != SelectedTag;
        }
        private void OnTagsChanged() => dgvTag.DataList = Tags;

        private void BindEvent()
        {
            txtName.TextChanged += (sender, args) =>
            {
                CurrTag.Name = ((TextBox)sender).Text;
                OnCurrTagChanged();
            };
            dgvTag.SelectionChanged += (sender, args) => SelectedTag = ((TagDataGridView)sender).SelectedItem;
        }
        private void InitControl()
        {
            dgvTag.SetColumns();
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                CurrTag.ID = DataAccess.NewTag(CurrTag);
                dgvTag.AddItem(CurrTag.ShollowClone());
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
                DataAccess.UpdateTag(CurrTag);
                dgvTag.UpdateCurrSelectedItem((ref Tag pro) =>
                {
                    pro.Name = CurrTag.Name;
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
                if(DialogResult.OK != MessageBoxEx.Confirm($"确定要删除 \"{CurrTag.Name}\" 吗？")) return;
                DataAccess.DeleteTag(CurrTag);
                dgvTag.RemoveCurrSelectedItem();
            }
            catch(Exception ex)
            {
                MessageBoxEx.Error(ex.Message);
            }
        }
        private void CmsDgvTag_Opening(object sender, CancelEventArgs e) => e.Cancel = dgvTag.SelectedItem == null;
        private void FrmTag_Load(object sender, EventArgs e) => Tags = new TagList(DataAccess.GetTag().ToList());
    }
}