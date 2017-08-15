using System;
using AniSuki.View.Templete;

namespace AniSuki.View
{
    public partial class FrmMain : FrmBase
    {
        public FrmMain() => InitializeComponent();

        private void BtnNewAnime_Click(object sender, EventArgs e) => new FrmNewAnime().Show();
        private void BtnBrowse_Click(object sender, EventArgs e) => new FrmBrowse().Show();
        private void MenuProducer_Click(object sender, EventArgs e) => new FrmProducer().Show();
        private void MenuResolution_Click(object sender, EventArgs e) => new FrmResolution().Show();
        private void MenuTag_Click(object sender, EventArgs e) => new FrmTag().Show();
        private void MenuVoiceActor_Click(object sender, EventArgs e) => new FrmVoiceActor().Show();
    }
}