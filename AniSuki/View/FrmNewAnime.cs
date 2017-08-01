using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            dgvCast.DataList = new CastList();
            btnNewCast.Enabled = false;
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
            }
        }

        private void DgvAnimeFile_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmRename frmRename = new FrmRename(Path.GetFileNameWithoutExtension(dgvAnimeFile.SelectedItem.Rename));
            if(DialogResult.OK == frmRename.ShowDialog())
            {
                dgvAnimeFile.UpdateCurrSelectedItem((ref AnimeFile file) => file.Rename = Path.ChangeExtension(frmRename.NewName, Path.GetExtension(file.FilePath)));
            }
        }

        private void FrmNewAnime_Load(object sender, EventArgs e)
        {
            LoadAnimeFile();
            LoadResolutions();
            LoadProducers();
            LoadTags();
            LoadVoiceActors();
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
    }
}