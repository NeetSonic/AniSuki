using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace AniSuki.Model
{
    public sealed class Tag
    {
        public int ID{ get; set; }
        public string Name{ get; set; }

        public static Tag FromDataRow(DataRow dr)
        {
            return new Tag
            {
                ID = dr.Field<int>(nameof(ID)),
                Name = dr.Field<string>(nameof(Name))
            };
        }
        public Tag ShollowClone()
        {
            return (Tag)MemberwiseClone();
        }
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