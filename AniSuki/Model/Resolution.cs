using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

namespace AniSuki.Model
{
    public sealed class Resolution
    {
        public Resolution() { }
        public Resolution(Size size)
        {
            Width = Convert.ToInt16(size.Width);
            Height = Convert.ToInt16(size.Height);
        }
        public Resolution(string res)
        {
            int flag = res.IndexOf('x');
            Width = short.Parse(res.Substring(0, flag));
            Height = short.Parse(res.Substring(flag + 1));
        }

        public int ID{ get; set; }
        public short Width{ get; set; }
        public short Height{ get; set; }
        public string ResolutionString => string.Format($@"{Width}x{Height}");

        public static bool operator >(Resolution r1, Resolution r2)
        {
            if(null == r1)
            {
                return false;
            }
            if(null == r2)
            {
                return true;
            }
            return r1.Width == r2.Width ? r1.Height > r2.Height : r1.Width > r2.Width;
        }
        public static bool operator <(Resolution r1, Resolution r2)
        {
            if(null == r2)
            {
                return false;
            }
            if(null == r1)
            {
                return true;
            }
            return r1.Width == r2.Width ? r1.Height < r2.Height : r1.Width < r2.Width;
        }
        public static int operator -(Resolution r1, Resolution r2)
        {
            if(r1 > r2)
            {
                return 1;
            }
            if(r1 < r2)
            {
                return -1;
            }
            return 0;
        }
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
        public bool ValueEquals(Resolution res)
        {
            return Width == res.Width && Height == res.Height;
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