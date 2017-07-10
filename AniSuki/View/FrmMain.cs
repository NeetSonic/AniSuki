using AniSuki.View.Templete;

namespace AniSuki.View
{
    public partial class FrmMain : FrmBase
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void MenuProducer_Click(object sender, System.EventArgs e)
        {
            new FrmProducer().ShowDialog();
        }

        private void MenuResolution_Click(object sender, System.EventArgs e)
        {
            new FrmResolution().ShowDialog();
        }

        private void MenuTag_Click(object sender, System.EventArgs e)
        {
            new FrmTag().ShowDialog();
        }

        private void MenuVoiceActor_Click(object sender, System.EventArgs e)
        {
            new FrmVoiceActor().ShowDialog();
        }
    }
}