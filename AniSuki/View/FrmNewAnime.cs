using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AniSuki.Model;
using AniSuki.Util;
using AniSuki.View.Functional;
using AniSuki.View.Templete;
using Neetsonic.Tool;

namespace AniSuki.View
{
    public partial class FrmNewAnime : FrmBase
    {
        public FrmNewAnime()
        {
            InitializeComponent();
            InitControl();
            BindEvent();
        }

        private Cast _currCast = new Cast();

        private IList<Resolution> _resolutions;

        private IList<Resolution> Resolutions
        {
            get => _resolutions;
            set
            {
                _resolutions = value;
                OnResolutionsChanged();
            }
        }

        private Cast CurrCast
        {
            get => _currCast;
            set
            {
                _currCast = value;
                OnCurrCastChanged();
            }
        }

        private Anime NewAnime{ get; } = new Anime();

        private AnimeFileList AnimeFiles => (AnimeFileList)dgvAnimeFile.DataList;

        private void OnNewAnimeChanged()
        {
            btnNewAnime.Enabled =
                    !string.IsNullOrWhiteSpace(NewAnime.Name)
                    &&
                    NewAnime.ProducerID != 0
                    &&
                    NewAnime.ResolutionID != 0
                    &&
                    NewAnime.SaleDate != DateTime.MinValue
                    &&
                    AnimeFiles.Count > 0;
        }

        private void OnCurrCastChanged()
        {
            btnNewCast.Enabled = !string.IsNullOrWhiteSpace(CurrCast?.CharaName) && CurrCast?.VoiceActorID != 0;
        }

        private void OnResolutionsChanged()
        {
            cmbResolution.DataSource = Resolutions;
            cmbResolution.DisplayMember = @"ResolutionString";
            cmbResolution.ValueMember = @"ID";
            cmbResolution.SelectedItem = null;
        }

        private void InitControl()
        {
            dgvAnimeFile.SetColumns();
            dgvCast.SetColumns();
            btnNewCast.Enabled = false;
            btnNewAnime.Enabled = false;
        }

        private void BindEvent()
        {
            txtCharaName.TextChanged += (sender, args) =>
            {
                CurrCast.CharaName = ((TextBox)sender).Text;
                OnCurrCastChanged();
            };
            cmbVoiceActor.SelectedIndexChanged += (sender, args) =>
            {
                VoiceActor voiceActor = (VoiceActor)cmbVoiceActor.SelectedItem;
                if(null == voiceActor)
                {
                    CurrCast.VoiceActorID = 0;
                    CurrCast.VoiceActor = null;
                }
                else
                {
                    CurrCast.VoiceActorID = voiceActor.ID;
                    CurrCast.VoiceActor = voiceActor.Name;
                }
                OnCurrCastChanged();
            };
            txtName.TextChanged += (sender, args) =>
            {
                NewAnime.Name = txtName.Text;
                OnNewAnimeChanged();
            };
            cmbProducer.SelectedIndexChanged += (sender, args) =>
            {
                Producer producer = (Producer)cmbProducer.SelectedItem;
                if(null == producer)
                {
                    NewAnime.ProducerID = 0;
                    NewAnime.Producer = null;
                }
                else
                {
                    NewAnime.ProducerID = producer.ID;
                    NewAnime.Producer = producer.Name;
                }
                OnNewAnimeChanged();
            };
            cmbResolution.SelectedIndexChanged += (sender, args) =>
            {
                Resolution resolution = (Resolution)cmbResolution.SelectedItem;
                if(null == resolution)
                {
                    NewAnime.ResolutionID = 0;
                    NewAnime.Resolution = null;
                }
                else
                {
                    NewAnime.ResolutionID = resolution.ID;
                    NewAnime.Resolution = resolution.ResolutionString;
                }
                OnNewAnimeChanged();
            };
            dateSale.ValueChanged += (sender, args) =>
            {
                NewAnime.SaleDate = dateSale.Value;
                OnNewAnimeChanged();
            };
        }

        private void LoadAnimeFile()
        {
            dgvAnimeFile.DataList = new AnimeFileList();
        }

        private void LoadResolutions()
        {
            Resolutions = DataAccess.GetResolution().ToList();
        }

        private void LoadProducers()
        {
            cmbProducer.DataSource = DataAccess.GetProducer().ToList();
            cmbProducer.DisplayMember = @"Name";
            cmbProducer.ValueMember = @"ID";
            cmbProducer.SelectedItem = null;
        }

        private void LoadTags()
        {
            clstTag.DataList = new TagList(DataAccess.GetTag().ToList());
        }

        private void LoadVoiceActors()
        {
            cmbVoiceActor.DataSource = DataAccess.GetVoiceActor().ToList();
            cmbVoiceActor.DisplayMember = @"Name";
            cmbVoiceActor.ValueMember = @"ID";
            cmbVoiceActor.SelectedItem = null;
        }

        private void LoadCast()
        {
            dgvCast.DataList = new CastList();
        }

        private void BtnNewFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog
            {
                Multiselect = true,
                Title = @"添加文件"
            };
            if(DialogResult.OK == fileDlg.ShowDialog())
            {
                Resolution maxRes = (Resolution)cmbResolution.SelectedItem;
                foreach(string filePath in fileDlg.FileNames)
                {
                    if(dgvAnimeFile.DataList.All(file => file.FilePath != filePath))
                    {
                        if(MediaInfoTool.IsVideo(filePath))
                        {
                            Resolution currRes = new Resolution(MediaInfoTool.GetVideoRes(filePath));
                            if(currRes > maxRes)
                            {
                                maxRes = currRes;
                            }
                        }
                        dgvAnimeFile.AddItem(new AnimeFile(filePath));
                    }
                }

                if(null != maxRes)
                {
                    Resolution theRes = Resolutions.FirstOrDefault(res => res.ValueEquals(maxRes));
                    if(null != theRes)
                    {
                        cmbResolution.SelectedItem = theRes;
                    }
                    else
                    {
                        DataAccess.NewResolution(maxRes);
                        LoadResolutions();
                        cmbResolution.SelectedItem = Resolutions.FirstOrDefault(res => res.ValueEquals(maxRes));
                    }
                }
                OnNewAnimeChanged();
            }
        }

        private void DgvAnimeFile_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmRename frmRename = new FrmRename(Path.GetFileNameWithoutExtension(dgvAnimeFile.SelectedItem.Rename));
            if(DialogResult.OK == frmRename.ShowDialog())
            {
                dgvAnimeFile.UpdateCurrSelectedItem((ref AnimeFile file) => file.Rename = string.Concat(frmRename.NewName, Path.GetExtension(file.FilePath)));
            }
        }

        private void FrmNewAnime_Load(object sender, EventArgs e)
        {
            LoadAnimeFile();
            LoadResolutions();
            LoadProducers();
            LoadTags();
            LoadVoiceActors();
            LoadCast();
        }

        private void BtnManageProducer_Click(object sender, EventArgs e)
        {
            new FrmProducer().ShowDialog();
            LoadProducers();
        }

        private void BtnManageTag_Click(object sender, EventArgs e)
        {
            new FrmTag().ShowDialog();
            LoadTags();
        }

        private void BtnCheckAllTag_Click(object sender, EventArgs e)
        {
            clstTag.CheckAll();
        }

        private void BtnReverseCheckTag_Click(object sender, EventArgs e)
        {
            clstTag.ReverseCheck();
        }

        private void BtnUncheckAllTag_Click(object sender, EventArgs e)
        {
            clstTag.UncheckAll();
        }

        private void BtnManageVoiceActor_Click(object sender, EventArgs e)
        {
            new FrmVoiceActor().ShowDialog();
            LoadVoiceActors();
        }

        private void BtnNewCast_Click(object sender, EventArgs e)
        {
            dgvCast.AddItem(CurrCast.ShollowClone());
            txtCharaName.Text = null;
        }

        private void MenuDgvCast_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = dgvCast.SelectedItem == null;
        }

        private void MenuDeleteCast_Click(object sender, EventArgs e)
        {
            dgvCast.RemoveCurrSelectedItem();
        }

        private void BtnNewAnime_Click(object sender, EventArgs e)
        {
            TaskNewAnime();
        }

        private void AsyncLog(string log)
        {
            BeginInvoke(new MethodInvoker(()=>txtLog.WriteLog(log)));
        }

        private async void TaskNewAnime()
        {
            await Task.Run(() =>
            {
                AsyncLog(@"开始添加动画...");
                AsyncLog(@"创建动画结构目录...");
                string animeDir = Path.Combine(Config.RootDir, NewAnime.Name);
                string coverDir = Path.Combine(animeDir, @"Cover");
                Directory.CreateDirectory(animeDir);
                Directory.CreateDirectory(coverDir);
                AsyncLog(@"开始拷贝文件...");
                foreach(AnimeFile animeFile in AnimeFiles)
                {
                    AsyncLog(string.Format($@"拷贝[{animeFile.Rename}]..."));
                    string srcFile = animeFile.FilePath;
                    string dstFile = Path.Combine(MediaInfoTool.IsImage(srcFile) ? coverDir : animeDir, animeFile.Rename);
                    File.Copy(srcFile, dstFile, true);
                }
                AsyncLog(@"写入数据库...");
                NewAnime.Tags = clstTag.Items.Cast<object>().Where((t, idx) => clstTag.GetItemChecked(idx)).Cast<Tag>();
                NewAnime.Casts = dgvCast.DataList.AsEnumerable();
                DataAccess.NewAnime(NewAnime);
                if(chkDeleteWhenSucceed.Checked)
                {
                    AsyncLog(@"删除原文件...");
                    FileTool.DeleteFiles(AnimeFiles.Select(file=>file.FilePath));
                }
                AsyncLog(@"添加动画完毕！");
            });
            MessageBoxEx.Info(@"添加动画成功！");
        }

        private void MenuDgvAnimeFile_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = dgvAnimeFile.SelectedItem == null;
        }

        private void MenuDeleteAnimeFile_Click(object sender, EventArgs e)
        {
            dgvAnimeFile.RemoveCurrSelectedItem();
            OnNewAnimeChanged();
        }
    }
}