using System.Windows.Forms;
using AniSuki.Model;
using Neetsonic.Control;

namespace AniSuki.View.Control
{
    public partial class ProducerDataGridView : BindingDataGridView<Producer>
    {
        public ProducerDataGridView() => InitializeComponent();

        public void SetColumns()
        {
            SetColumnsCore(new[]
            {
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"Name",
                    HeaderText = @"公司名称"
                },
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"Website",
                    HeaderText = @"官方网站",
                    Type = typeof(DataGridViewLinkColumn),
                    SortMode = DataGridViewColumnSortMode.NotSortable
                }
            });
        }
        protected override bool IsTheSameItem(Producer t1, Producer t2) => t1.ID == t2.ID;
    }
}