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
            new FrmProducer().Show();
        }

        private void MenuResolution_Click(object sender, System.EventArgs e)
        {
            new FrmResolution().Show();
        }

        private void MenuTag_Click(object sender, System.EventArgs e)
        {
            new FrmTag().Show();
        }

        private void MenuVoiceActor_Click(object sender, System.EventArgs e)
        {
            new FrmVoiceActor().Show();
        }

        private void btnNewAnime_Click(object sender, System.EventArgs e)
        {
            new FrmNewAnime().Show();
        }

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            new FrmBrowse().Show();
        }
    }
}