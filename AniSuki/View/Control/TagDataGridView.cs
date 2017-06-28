using AniSuki.Model;
using Neetsonic.Control;

namespace AniSuki.View.Control
{
    public partial class TagDataGridView : BindingDataGridView<Tag>
    {
        public TagDataGridView()
        {
            InitializeComponent();
        }

        public void SetColumns()
        {
            SetColumnsCore(new[]
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
                    HeaderText = @"标签名称"
                }
            });
        }
        protected override bool IsTheSameItem(Tag t1, Tag t2)
        {
            return t1.ID == t2.ID;
        }
    }
}