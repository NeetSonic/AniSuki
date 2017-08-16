using AniSuki.Model;
using Neetsonic.Control;

namespace AniSuki.View.Control
{
    public partial class ResolutionDataGridView : BindingDataGridView<Resolution>
    {
        public ResolutionDataGridView() => InitializeComponent();

        public void SetColumns()
        {
            SetColumnsCore(new[]
            {
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"ResolutionString",
                    HeaderText = @"分辨率"
                }
            });
        }
        protected override bool IsTheSameItem(Resolution t1, Resolution t2) => t1.ID == t2.ID;
    }
}