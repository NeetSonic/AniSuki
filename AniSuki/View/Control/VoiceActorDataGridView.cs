using AniSuki.Model;
using Neetsonic.Control;

namespace AniSuki.View.Control
{
    public partial class VoiceActorDataGridView : BindingDataGridView<VoiceActor>
    {
        public VoiceActorDataGridView() => InitializeComponent();

        public void SetColumns()
        {
            SetColumnsCore(new[]
            {
                new BindingDataGridViewColumn
                {
                    NameAndDataPropertyName = @"Name",
                    HeaderText = @"声优名称"
                }
            });
        }
        protected override bool IsTheSameItem(VoiceActor t1, VoiceActor t2) => t1.ID == t2.ID;
    }
}