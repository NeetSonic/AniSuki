using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Neetsonic.Tool;
using Neetsonic.Tool.Extensions;

namespace AniSuki.Model
{
    public sealed class Producer
    {
        public Producer(){}
        public Producer(DataRow dr)
        {
            ID = dr.FieldInt(nameof(ID));
            Name = dr.FieldString(nameof(Name));
            Website = dr.FieldString(nameof(Website));
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }

        public Producer ShollowClone() => (Producer)MemberwiseClone();
    }

    public sealed class ProducerList : Neetsonic.DataStructure.BindingList<Producer>
    {
        public ProducerList(IList<Producer> lst) : base(lst) { }

        protected override int Cmp(PropertyDescriptor property, ListSortDirection direction, Producer x, Producer y)
        {
            int flag = direction == ListSortDirection.Ascending ? 1 : -1;
            switch(property.Name)
            {
                case @"Name": return flag * string.Compare(x.Name, y.Name, StringComparison.CurrentCulture);
                default: return 0;
            }
        }
    }
}