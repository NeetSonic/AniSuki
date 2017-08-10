using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            InitControls();
            BindEvents();
        }
        private void BindEvents()
        {
            dgvAnime.SelectionChanged += (sender, args) =>
            {
                Anime anime = dgvAnime.SelectedItem;
                if(null == anime)
                {
                    dgvTag.DataList = null;
                    dgvCast.DataList = null;
                    txtComment.Text = null;
                }
                else
                {
                    dgvTag.DataList = new TagList(anime.Tags.ToList());
                    dgvCast.DataList = new CastList(anime.Casts.ToList());
                    txtComment.Text = anime.Comment;
                }
            };
        }
        private void InitControls()
        {
            dgvAnime.SetColumns();
            dgvCast.SetColumns();
            dgvTag.SetColumns();
        }

        private string FilterName => txtFilterName.Text;
        private int? FilterProducerID => ((Producer)cmbFilterProducer.SelectedItem)?.ID;
        private int? FilterResolutionID => ((Resolution)cmbFilterResolution.SelectedItem)?.ID;
        private DateTime? FilterSaleDateAfter => dateFilterSaleDateAfter.Value;
        private DateTime? FilterSaleDateBefore => dateFilterSaleDateAfter.Value;

        private void LoadProducers()
        {
            cmbFilterProducer.DataSource = DataAccess.GetProducer().ToList();
            cmbFilterProducer.DisplayMember = @"Name";
            cmbFilterProducer.ValueMember = @"ID";
            cmbFilterProducer.SelectedItem = null;
        }
        private void LoadResolutions()
        {
            cmbFilterResolution.DataSource = DataAccess.GetResolution().ToList();
            cmbFilterResolution.DisplayMember = @"ResolutionString";
            cmbFilterResolution.ValueMember = @"ID";
            cmbFilterResolution.SelectedItem = null;
        }

        private void LoadTags()
        {
            clstFilterTagAnd.DataList = new TagList(DataAccess.GetTag().ToList());
            clstFilterTagOr.DataList = new TagList(DataAccess.GetTag().ToList());
        }
        private void LoadVoiceActors()
        {
            clstFilterVoiceActorAnd.DataList = new VoiceActorList(DataAccess.GetVoiceActor().ToList());
            clstFilterVoiceActorOr.DataList = new VoiceActorList(DataAccess.GetVoiceActor().ToList());
        }

        private async void TaskSearch()
        {
            // 生成过滤条件
            List<string> filters = new List<string>();
            IEnumerable<int> filterTagIDAnd = clstFilterTagAnd.Items.Cast<object>().Where((t, idx) => clstFilterTagAnd.GetItemChecked(idx)).Cast<Tag>().Select(tag => tag.ID);
            IEnumerable<int> filterTagIDOr = clstFilterTagOr.Items.Cast<object>().Where((t, idx) => clstFilterTagOr.GetItemChecked(idx)).Cast<Tag>().Select(tag => tag.ID);
            IEnumerable<int> filterVoiceActorIDAnd = clstFilterVoiceActorAnd.Items.Cast<object>().Where((t, idx) => clstFilterVoiceActorAnd.GetItemChecked(idx)).Cast<VoiceActor>().Select(VoiceActor => VoiceActor.ID);
            IEnumerable<int> filterVoiceActorIDOr = clstFilterVoiceActorOr.Items.Cast<object>().Where((t, idx) => clstFilterVoiceActorOr.GetItemChecked(idx)).Cast<VoiceActor>().Select(VoiceActor => VoiceActor.ID);
            if(!string.IsNullOrWhiteSpace(FilterName))
            {
                filters.Add(string.Format($@"Name LIKE N'%{FilterName.Trim()}%'"));
            }
            if(null != FilterProducerID)
            {
                filters.Add(string.Format($@"ProducerID = {FilterProducerID.Value}"));
            }
            if(null != FilterResolutionID)
            {
                filters.Add(string.Format($@"ResolutionID = {FilterResolutionID.Value}"));
            }
            if(null != FilterSaleDateAfter)
            {
                filters.Add(string.Format($@"DATEDIFF(dd, SaleDate, '{FilterSaleDateAfter.Value.ToShortDateString()}') <= 0"));
            }
            if(null != FilterSaleDateBefore)
            {
                filters.Add(string.Format($@"DATEDIFF(dd, SaleDate, '{FilterSaleDateBefore.Value.ToShortDateString()}') <= 0"));
            }
            if(filterTagIDAnd.Any())
            {

                filters.Add(string.Format($@"ID IN
	            (
		            SELECT AnimeID FROM AnimeTag WHERE TagID IN({string.Join(@",", filterTagIDAnd)}) GROUP BY AnimeID HAVING COUNT(*) = {filterTagIDAnd.Count()}
	            )"));
            }
            if(filterTagIDOr.Any())
            {
                filters.Add(string.Format($@"ID IN
	            (
		            SELECT DISTINCT AnimeID FROM AnimeTag WHERE TagID IN({string.Join(@",", filterTagIDOr)})
	            )"));
            }
            if(filterVoiceActorIDAnd.Any())
            {

                filters.Add(string.Format($@"ID IN
	            (
		            SELECT AnimeID FROM [Cast] WHERE VoiceActorID IN({string.Join(@",", filterVoiceActorIDAnd)}) GROUP BY AnimeID HAVING COUNT(*) = {filterVoiceActorIDAnd.Count()}
	            )"));
            }
            if(filterVoiceActorIDOr.Any())
            {
                filters.Add(string.Format($@"ID IN
	            (
		            SELECT DISTINCT AnimeID FROM [Cast] WHERE VoiceActorID IN({string.Join(@",", filterVoiceActorIDOr)})
	            )"));
            }
            await Task.Run(() =>
            {
                AnimeList animes = new AnimeList(DataAccess.GetAnime(filters).ToList());
                BeginInvoke(new MethodInvoker(() =>dgvAnime.DataList = animes));
            });
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            TaskSearch();
        }

        private void FrmBrowse_Load(object sender, EventArgs e)
        {
            LoadProducers();
            LoadResolutions();
            LoadTags();
            LoadVoiceActors();
        }
    }
}