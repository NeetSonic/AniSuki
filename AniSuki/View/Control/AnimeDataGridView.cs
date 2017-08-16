using AniSuki.Model;
using Neetsonic.Control;

namespace AniSuki.View.Control
{
    public partial class AnimeDataGridView : BindingDataGridView<Anime>
    {
        public AnimeDataGridView() => InitializeComponent();

        public void SetColumns()
        {
            SetColumnsCore(new[]
            {
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"Name",
                    HeaderText = @"动画名称"
                },
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"Producer",
                    HeaderText = @"出版公司"
                },
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"Resolution",
                    HeaderText = @"分辨率"
                },
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"SaleDateString",
                    HeaderText = @"发售时间"
                }
            });
        }
        protected override bool IsTheSameItem(Anime t1, Anime t2) => t1.ID == t2.ID;
    }
}