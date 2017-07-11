using System;
using System.IO;
using System.Windows.Forms;
using AniSuki.Model;
using AniSuki.View.Functional;
using AniSuki.View.Templete;

namespace AniSuki.View
{
    public partial class FrmNewAnime : FrmBase
    {
        public FrmNewAnime()
        {
            InitializeComponent();
            InitControl();
        }

        private void InitControl()
        {
            dgvAnimeFile.SetColumns();
            dgvAnimeFile.DataList = new AnimeFileList();
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
                dgvAnimeFile.AddRangeUnique(fileDlg.FileNames);
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
    }
}