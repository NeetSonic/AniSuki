using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Neetsonic.Tool;
using Neetsonic.Tool.Extensions;

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
        public Resolution(string resString)
        {
            int flag = resString.IndexOf('x');
            Width = short.Parse(resString.Substring(0, flag));
            Height = short.Parse(resString.Substring(flag + 1));
        }
        public Resolution(DataRow dr)
        {
            ID = dr.FieldInt(nameof(ID));
            Width = dr.FieldShort(nameof(Width));
            Height = dr.FieldShort(nameof(Height));
        }

        public int ID { get; set; }
        public short Width { get; set; }
        public short Height { get; set; }
        public string ResolutionString => string.Format($@"{Width}x{Height}");

        public static bool operator >(Resolution r1, Resolution r2)
        {
            if(r1 is null) return false;
            if(r2 is null) return true;
            return r1.Width == r2.Width ? r1.Height > r2.Height : r1.Width > r2.Width;
        }
        public static bool operator <(Resolution r1, Resolution r2)
        {
            if(r2 is null) return false;
            if(r1 is null) return true;
            return r1.Width == r2.Width ? r1.Height < r2.Height : r1.Width < r2.Width;
        }
        public static int operator -(Resolution r1, Resolution r2)
        {
            if(r1 > r2) return 1;
            if(r1 < r2) return -1;
            return 0;
        }

        public static Resolution Max(Resolution r1, Resolution r2) => r1 > r2 ? r1 : r2;
        public Resolution ShollowClone() => (Resolution)MemberwiseClone();
        public bool ValueEquals(Resolution res) => Width == res.Width && Height == res.Height;
    }

    public sealed class ResolutionList : Neetsonic.DataStructure.BindingList<Resolution>
    {
        public ResolutionList(IList<Resolution> lst) : base(lst) { }

        protected override int Cmp(PropertyDescriptor property, ListSortDirection direction, Resolution x, Resolution y)
        {
            int flag = direction == ListSortDirection.Ascending ? 1 : -1;
            return flag * (x - y);
        }
    }
}