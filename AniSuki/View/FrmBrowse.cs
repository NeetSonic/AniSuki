using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AniSuki.Model;
using AniSuki.Util;
using AniSuki.View.Functional;
using AniSuki.View.Templete;
using Neetsonic.Tool;

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

        private string FilterName => txtFilterName.Text;
        private int? FilterProducerID => ((Producer)cmbFilterProducer.SelectedItem)?.ID;
        private int? FilterResolutionID => ((Resolution)cmbFilterResolution.SelectedItem)?.ID;
        private DateTime? FilterSaleDateAfter => dateFilterSaleDateAfter.Value;
        private DateTime? FilterSaleDateBefore => dateFilterSaleDateAfter.Value;
        private string CurrAnimeDir => Path.Combine(Config.RootDir, dgvAnime.SelectedItem.Name);
        private string CurrAnimeCoverDir => Path.Combine(Config.RootDir, dgvAnime.SelectedItem.Name, @"Cover");
        private Anime CurrAnime => dgvAnime.SelectedItem;

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
                    btnExplorer.Enabled = false;
                    btnFreshResolution.Enabled = false;
                    btnUpdateComment.Enabled = false;
                    btnUpdateCast.Enabled = false;
                    btnUpdateTag.Enabled = false;
                    picCover.Clear();
                }
                else
                {
                    dgvTag.DataList = new TagList(anime.Tags.ToList());
                    dgvCast.DataList = new CastList(anime.Casts.ToList());
                    txtComment.Text = anime.Comment;
                    btnExplorer.Enabled = true;
                    btnFreshResolution.Enabled = true;
                    btnUpdateComment.Enabled = true;
                    btnUpdateCast.Enabled = true;
                    btnUpdateTag.Enabled = true;
                    picCover.ChangePicFiles(Directory.GetFiles(CurrAnimeCoverDir, @"*.*", SearchOption.TopDirectoryOnly));
                }
            };
        }
        private void InitControls()
        {
            dgvAnime.SetColumns();
            dgvCast.SetColumns();
            dgvTag.SetColumns();
            btnExplorer.Enabled = false;
            btnFreshResolution.Enabled = false;
            btnUpdateComment.Enabled = false;
            btnUpdateCast.Enabled = false;
            btnUpdateTag.Enabled = false;
        }
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
        private void RefreshResolution()
        {
            Resolution oldRes = (Resolution)cmbFilterResolution.SelectedItem;
            LoadResolutions();
            if(null != oldRes) // 还原原来选中的筛选项
            {
                cmbFilterResolution.SelectedIndex = cmbFilterResolution.FindStringExact(oldRes.ResolutionString);
            }
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
                BeginInvoke(new MethodInvoker(() => dgvAnime.DataList = animes));
            });
        }

        private void FrmBrowse_Load(object sender, EventArgs e)
        {
            LoadProducers();
            LoadResolutions();
            LoadTags();
            LoadVoiceActors();
        }
        private void BtnSearch_Click(object sender, EventArgs e) => TaskSearch();
        private void BtnClearName_Click(object sender, EventArgs e) => txtFilterName.Text = null;
        private void BtnClearProducer_Click(object sender, EventArgs e) => cmbFilterProducer.SelectedItem = null;
        private void BtnClearResolution_Click(object sender, EventArgs e) => cmbFilterResolution.SelectedItem = null;
        private void BtnClearTagAnd_Click(object sender, EventArgs e) => clstFilterTagAnd.UncheckAll();
        private void BtnClearTagOr_Click(object sender, EventArgs e) => clstFilterTagOr.UncheckAll();
        private void BtnClearVoiceActorAnd_Click(object sender, EventArgs e) => clstFilterVoiceActorAnd.UncheckAll();
        private void BtnClearVoiceActorOr_Click(object sender, EventArgs e) => clstFilterVoiceActorOr.UncheckAll();
        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            txtFilterName.Text = null;
            cmbFilterProducer.SelectedItem = null;
            cmbFilterResolution.SelectedItem = null;
            clstFilterTagAnd.UncheckAll();
            clstFilterTagOr.UncheckAll();
            clstFilterVoiceActorAnd.UncheckAll();
            clstFilterVoiceActorOr.UncheckAll();
            dateFilterSaleDateAfter.Value = null;
            dateFilterSaleDateBefore.Value = null;
        }
        private void BtnExplorer_Click(object sender, EventArgs e)
        {
            string dir = CurrAnimeDir;
            if(Directory.Exists(dir))
            {
                FileTool.OpenDirectory(dir);
            }
            else
            {
                MessageBoxEx.Error(@"目录不存在！");
            }
        }
        private void BtnFreshResolution_Click(object sender, EventArgs e)
        {
            string dir = CurrAnimeDir;
            if(!Directory.Exists(dir))
            {
                MessageBoxEx.Error(@"目录不存在！");
                return;
            }
            Resolution resolution = new Resolution(CurrAnime.Resolution);
            Resolution maxRes = resolution.ShollowClone();
            foreach(string file in Directory.GetFiles(dir, @"*.*", SearchOption.TopDirectoryOnly))
            {
                if(MediaInfoTool.IsVideo(file))
                {
                    maxRes = Resolution.Max(maxRes, new Resolution(MediaInfoTool.GetVideoRes(file)));
                }
            }
            if(maxRes > resolution)
            {
                Resolution newRes = DataAccess.UpdateAnimeResolution(maxRes, CurrAnime.ID);
                dgvAnime.UpdateCurrSelectedItem((ref Anime anime) =>
                {
                    anime.ResolutionID = newRes.ID;
                    anime.Resolution = newRes.ResolutionString;
                });
                if(-1 == cmbFilterResolution.FindStringExact(newRes.ResolutionString))
                {
                    RefreshResolution(); // 新的分辨率，更新到筛选条件中
                }
            }
            MessageBoxEx.Info(@"更新成功！");
        }
        private void BtnUpdateComment_Click(object sender, EventArgs e)
        {
            FrmRecomment dlg = new FrmRecomment(CurrAnime.Comment);
            if(DialogResult.OK == dlg.ShowDialog())
            {
                DataAccess.UpdateAnimeComment(dlg.NewComment, CurrAnime.ID);
                CurrAnime.Comment = dlg.NewComment;
                txtComment.Text = dlg.NewComment;
            }
        }
        private void BtnUpdateTag_Click(object sender, EventArgs e)
        {
            FrmRetag dlg = new FrmRetag(CurrAnime.Tags.Select(tag => tag.ID));
            if(DialogResult.OK == dlg.ShowDialog())
            {
                IEnumerable<Tag> newTags = dlg.NewTags;
                DataAccess.UpdateAnimeTag(newTags, CurrAnime.ID);
                CurrAnime.Tags = newTags;
                dgvTag.DataList = new TagList(CurrAnime.Tags.ToList());
            }
        }
        private void BtnUpdateCast_Click(object sender, EventArgs e)
        {
            FrmRecast dlg = new FrmRecast(CurrAnime.Casts);
            if(DialogResult.OK == dlg.ShowDialog())
            {
                IEnumerable<Cast> newCasts = dlg.NewCasts;
                DataAccess.UpdateAnimeCast(newCasts, CurrAnime.ID);
                CurrAnime.Casts = newCasts;
                dgvCast.DataList = new CastList(CurrAnime.Casts.ToList());
            }
        }
    }
}