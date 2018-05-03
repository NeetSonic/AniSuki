using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Windows.Forms;
using Neetsonic.DataStructure;
using Neetsonic.Tool;

namespace AniSuki.Model
{
    public sealed class AniSukiConfig
    {
        private const string XmlElementStorePath = @"StorePath";
        private readonly XmlConfigManager config = new XmlConfigManager(Path.Combine(Application.StartupPath, @"config.xml"));

        [Browsable(false)]
        public string StorePath => config.ReadConfig(XmlElementStorePath, Application.UserAppDataPath);

        [EditorBrowsable(EditorBrowsableState.Never), Category("路径"), Description("动画文件的存储路径"), Editor(typeof(PropertyGridDirectoryItem), typeof(UITypeEditor))]
        public string 存储路径
        {
            get => StorePath;
            set => config.SaveConfig(XmlElementStorePath, value);
        }
    }
}