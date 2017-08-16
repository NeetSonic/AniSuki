using System;
using System.Windows.Forms;
using AniSuki.View.Templete;

namespace AniSuki.View.Functional
{
    public partial class FrmRedate : FrmBase
    {
        public FrmRedate(DateTime oldDate)
        {
            InitializeComponent();
            date.Value = oldDate;
        }

        public DateTime NewDate => date.Value;

        private void BtnOK_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;
    }
}