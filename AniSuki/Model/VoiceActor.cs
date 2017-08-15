using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Neetsonic.Tool;

namespace AniSuki.Model
{
    public sealed class VoiceActor
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static VoiceActor FromDataRow(DataRow dr) => new VoiceActor
        {
            ID = dr.FieldInt(nameof(ID)),
            Name = dr.FieldString(nameof(Name))
        };
        public VoiceActor ShollowClone() => (VoiceActor)MemberwiseClone();
    }

    public sealed class VoiceActorList : Neetsonic.DataStructure.BindingList<VoiceActor>
    {
        public VoiceActorList(IList<VoiceActor> lst) : base(lst) { }

        protected override int Cmp(PropertyDescriptor property, ListSortDirection direction, VoiceActor x, VoiceActor y)
        {
            int flag = direction == ListSortDirection.Ascending ? 1 : -1;
            return flag * string.Compare(x.Name, y.Name, StringComparison.CurrentCulture);
        }
    }
}