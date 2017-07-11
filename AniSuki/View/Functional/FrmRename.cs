using System.Windows.Forms;
using AniSuki.View.Templete;

namespace AniSuki.View.Functional
{
    public partial class FrmRename : FrmBase
    {
        public string NewName => txtName.Text;

        public FrmRename(string name)
        {
            InitializeComponent();
            txtName.Text = name;
            txtName.Highlight();
        }

        private void BtnOK_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}