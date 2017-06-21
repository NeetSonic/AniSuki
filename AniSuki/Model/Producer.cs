﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace AniSuki.Model
{
    public sealed class Producer
    {
        public int ID{ get; set; }
        public string Name{ get; set; }
        public string Website{ get; set; }

        public static Producer FromDataRow(DataRow dr)
        {
            return new Producer
            {
                ID = dr.Field<int>(nameof(ID)),
                Name = dr.Field<string>(nameof(Name)),
                Website = dr.Field<string>(nameof(Website))
            };
        }
        public Producer ShollowClone()
        {
            return (Producer)MemberwiseClone();
        }
    }

    public sealed class ProducerList : Neetsonic.DataStructure.BindingList<Producer>
    {
        public ProducerList(IList<Producer> lst) : base(lst) { }

        protected override int Cmp(PropertyDescriptor property, ListSortDirection direction, Producer x, Producer y)
        {
            int flag = direction == ListSortDirection.Ascending ? 1 : -1;
            switch(property.Name)
            {
                case @"Name":
                {
                    return flag * string.Compare(x.Name, y.Name, StringComparison.CurrentCulture);
                }
                case @"Website":
                {
                    int ret = string.Compare(x.Website, y.Website, StringComparison.CurrentCulture);
                    return flag * (ret == 0 ? string.Compare(x.Name, y.Name, StringComparison.CurrentCulture) : ret);
                }
                default:
                {
                    return 0;
                }
            }
        }
    }
}