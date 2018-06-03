using System;
using AniSuki.Util;
using AniSuki.View.Templete;

namespace AniSuki.View
{
    public partial class FrmConfig : FrmBase
    {
        public FrmConfig() => InitializeComponent();

        private void FrmConfig_Load(object sender, EventArgs e) => prop.SelectedObject = Global.Config;
    }
}