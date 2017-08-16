using AniSuki.Model;
using Neetsonic.Control;

namespace AniSuki.View.Control
{
    public partial class AnimeFileDataGridView : BindingDataGridView<AnimeFile>
    {
        public AnimeFileDataGridView() => InitializeComponent();

        public void SetColumns()
        {
            SetColumnsCore(new[]
            {
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"Rename",
                    HeaderText = @"文件名"
                }
            });
        }
        protected override bool IsTheSameItem(AnimeFile t1, AnimeFile t2) => t1.FilePath == t2.FilePath;
    }
}