using System.Windows.Forms;
using AniSuki.Model;
using Neetsonic.Control;

namespace AniSuki.View.Control
{
    public partial class ProducerDataGridView : BindingDataGridView<Producer>
    {
        public ProducerDataGridView()
        {
            InitializeComponent();
        }

        public void SetColumns()
        {
            SetColumns(new[]
            {
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"ID",
                    HeaderText = @"编号",
                    Visible = false
                },
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
        protected override bool IsTheSameItem(Producer t1, Producer t2)
        {
            return t1.ID == t2.ID;
        }
    }
}