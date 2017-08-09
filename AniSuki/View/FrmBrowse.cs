using System.Linq;
using AniSuki.Model;
using AniSuki.Util;
using AniSuki.View.Templete;

namespace AniSuki.View
{
    public partial class FrmBrowse : FrmBase
    {
        public FrmBrowse()
        {
            InitializeComponent();
            dgvAnime.SetColumns();
        }

        private string FilterName => txtFilterName.Text;
        private int? FilterProducerID => ((Producer)cmbFilterProducer.SelectedItem)?.ID;
        private int? FilterResolutionID => ((Resolution)cmbFilterResolution.SelectedItem)?.ID;

        private void FrmBrowse_Load(object sender, System.EventArgs e)
        {
            dgvAnime.DataList = new Anime.AnimeList(DataAccess.GetAnime(null).ToList());
        }
    }
}