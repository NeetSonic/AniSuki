using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AniSuki.Model;
using AniSuki.Util;
using AniSuki.View.Templete;

namespace AniSuki.View.Functional
{
    public partial class FrmRetag : FrmBase
    {
        private readonly IEnumerable<int> _tagIDs;

        public FrmRetag(IEnumerable<int> tagIDs)
        {
            _tagIDs = tagIDs;
            InitializeComponent();
        }

        public IEnumerable<Tag> NewTags => clstTag.CheckedItems.Cast<Tag>();

        private void BtnOK_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;
        private void FrmRetag_Load(object sender, EventArgs e)
        {
            LoadTags();
            foreach(int tagID in _tagIDs)
            {
                int idx = clstTag.DataList.FindItemIndex(tag => tag.ID == tagID);
                if(-1 != idx)
                {
                    clstTag.SetItemChecked(idx, true);
                }
            }
        }
        private void LoadTags()
        {
            clstTag.DataList = new TagList(DataAccess.GetTag().ToList());
        }

        private void BtnManageTag_Click(object sender, EventArgs e)
        {
            new FrmTag().ShowDialog();
            LoadTags();
        }
    }
}