using System.Collections.Generic;
using System.Linq;
using AniSuki.Model;
using Neetsonic.Control;

namespace AniSuki.View.Control
{
    public partial class AnimeFileDataGridView : BindingDataGridView<AnimeFile>
    {
        public AnimeFileDataGridView()
        {
            InitializeComponent();
        }
        public void AddRangeUnique(IEnumerable<string> filePaths)
        {
            foreach(string filePath in filePaths)
            {
                if(DataList.All(file => file.FilePath != filePath))
                {
                    AddItem(new AnimeFile(filePath));
                }
            }
        }
        public void SetColumns()
        {
            SetColumnsCore(new[]
            {
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"FilePath",
                    HeaderText = @"文件路径",
                    Visible = false
                },
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"Name",
                    HeaderText = @"原文件名",
                    Visible = false
                },
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"Rename",
                    HeaderText = @"文件名"
                }
            });
        }
        protected override bool IsTheSameItem(AnimeFile t1, AnimeFile t2)
        {
            return t1.FilePath == t2.FilePath;
        }
    }
}