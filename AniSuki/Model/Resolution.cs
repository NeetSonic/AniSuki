using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace AniSuki.Model
{
    public sealed class Resolution
    {
        public int ID{ get; set; }
        public short Width{ get; set; }
        public short Height{ get; set; }
        public string ResolutionString => string.Format($"{Width}x{Height}");

        public static Resolution FromDataRow(DataRow dr)
        {
            return new Resolution
            {
                ID = dr.Field<int>(nameof(ID)),
                Width = dr.Field<short>(nameof(Width)),
                Height = dr.Field<short>(nameof(Height))
            };
        }
        public Resolution ShollowClone()
        {
            return (Resolution)MemberwiseClone();
        }
    }

    public sealed class ResolutionList : Neetsonic.DataStructure.BindingList<Resolution>
    {
        public ResolutionList(IList<Resolution> lst) : base(lst) { }

        protected override int Cmp(PropertyDescriptor property, ListSortDirection direction, Resolution x, Resolution y)
        {
            int flag = direction == ListSortDirection.Ascending ? 1 : -1;
            int ret = x.Width - y.Width;
            return flag * (ret == 0 ? x.Height - y.Height : ret);
        }
    }
}