using System;
using System.Windows.Forms;
using AniSuki.View.Templete;

namespace AniSuki.View.Functional
{
    public partial class FrmRename : FrmBase
    {
        public FrmRename(string name)
        {
            InitializeComponent();
            txtName.Text = name;
            txtName.Highlight();
        }

        public string NewName => txtName.Text;

        private void BtnOK_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;
    }
}