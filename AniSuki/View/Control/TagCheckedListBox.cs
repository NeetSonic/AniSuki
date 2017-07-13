using AniSuki.Model;
using Neetsonic.Control;

namespace AniSuki.View.Control
{
    public partial class TagCheckedListBox : BindingCheckedListBox<Tag>
    {
        public TagCheckedListBox()
        {
            InitializeComponent();
        }

        protected override string DisplayMemberName => @"Name";
        protected override string ValueMemberName => @"ID";

        protected override bool IsTheSameItem(Tag t1, Tag t2)
        {
            return t1.ID == t2.ID;
        }
    }
}