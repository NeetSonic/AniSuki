using System;
using System.Windows.Forms;
using AniSuki.View.Templete;

namespace AniSuki.View.Functional
{
    public partial class FrmRecomment : FrmBase
    {
        public FrmRecomment(string comment)
        {
            InitializeComponent();
            txtComment.Text = comment;
            txtComment.Highlight();
        }
        public string NewComment => txtComment.Text;

        private void BtnOK_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;
    }
}