using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Neetsonic.Tool;

namespace AniSuki.Model
{
    public sealed class Tag
    {
        public Tag(){}
        public Tag(DataRow dr)
        {
            ID = dr.FieldInt(nameof(ID));
            Name = dr.FieldString(nameof(Name));
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public Tag ShollowClone() => (Tag)MemberwiseClone();
    }

    public sealed class TagList : Neetsonic.DataStructure.BindingList<Tag>
    {
        public TagList(IList<Tag> lst) : base(lst) { }

        protected override int Cmp(PropertyDescriptor property, ListSortDirection direction, Tag x, Tag y)
        {
            int flag = direction == ListSortDirection.Ascending ? 1 : -1;
            return flag * string.Compare(x.Name, y.Name, StringComparison.CurrentCulture);
        }
    }
}