using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace AniSuki.Model
{
    public class VoiceActor
    {
        public int ID{ get; set; }
        public string Name{ get; set; }

        public static VoiceActor FromDataRow(DataRow dr)
        {
            return new VoiceActor
            {
                ID = dr.Field<int>(nameof(ID)),
                Name = dr.Field<string>(nameof(Name))
            };
        }
        public VoiceActor ShollowClone()
        {
            return (VoiceActor)MemberwiseClone();
        }
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