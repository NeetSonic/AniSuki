using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace AniSuki.Model
{
    public sealed class Cast
    {
        public string CharaName { get; set; }
        public string VoiceActor { get; set; }
        public int VoiceActorID { get; set; }

        public static Cast FromDataRow(DataRow dr) => new Cast
        {
            VoiceActorID = dr.Field<int>(nameof(VoiceActorID)),
            CharaName = dr.Field<string>(nameof(CharaName)),
            VoiceActor = dr.Field<string>(nameof(VoiceActor))
        };
        public Cast ShollowClone() => (Cast)MemberwiseClone();
    }

    public sealed class CastList : Neetsonic.DataStructure.BindingList<Cast>
    {
        public CastList() { }
        public CastList(IList<Cast> lst) : base(lst) { }

        protected override int Cmp(PropertyDescriptor property, ListSortDirection direction, Cast x, Cast y) => -1;
    }
}