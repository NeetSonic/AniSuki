using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Neetsonic.Tool;

namespace AniSuki.Model
{
    public sealed class Cast
    {
        public Cast() { }
        public Cast(DataRow dr)
        {
            VoiceActorID = dr.FieldInt(nameof(VoiceActorID));
            CharaName = dr.FieldString(nameof(CharaName));
            VoiceActor = dr.FieldString(nameof(VoiceActor));
        }

        public string CharaName { get; set; }
        public string VoiceActor { get; set; }
        public int VoiceActorID { get; set; }

        public Cast ShollowClone() => (Cast)MemberwiseClone();
    }

    public sealed class CastList : Neetsonic.DataStructure.BindingList<Cast>
    {
        public CastList() { }
        public CastList(IList<Cast> lst) : base(lst) { }

        protected override int Cmp(PropertyDescriptor property, ListSortDirection direction, Cast x, Cast y) => -1;
    }
}