using AniSuki.Model;
using Neetsonic.Control;

namespace AniSuki.View.Control
{
    public partial class VoiceActorCheckedListBox : BindingCheckedListBox<VoiceActor>
    {
        public VoiceActorCheckedListBox() => InitializeComponent();

        protected override string DisplayMemberName => @"Name";
        protected override string ValueMemberName => @"ID";

        protected override bool IsTheSameItem(VoiceActor t1, VoiceActor t2) => t1.ID == t2.ID;
    }
}