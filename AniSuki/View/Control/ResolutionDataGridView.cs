
using System.Windows.Forms;
using AniSuki.Model;
using Neetsonic.Control;

namespace AniSuki.View.Control
{
    public partial class ResolutionDataGridView : BindingDataGridView<Resolution>
    {
        public ResolutionDataGridView()
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
                    NameAndDataPropertyName = @"Width",
                    HeaderText = @"宽度",
                    Visible = false
                },
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"Height",
                    HeaderText = @"高度",
                    Visible = false
                },
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"ResolutionString",
                    HeaderText = @"分辨率"
                }
            });
        }
        protected override bool IsTheSameItem(Resolution t1, Resolution t2)
        {
            return t1.ID == t2.ID;
        }
    }
}