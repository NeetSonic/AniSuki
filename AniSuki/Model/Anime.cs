using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace AniSuki.Model
{
    public sealed class Anime
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public DateTime SaleDate { get; set; }
        public int ProducerID { get; set; }
        public string Producer { get; set; }
        public int ResolutionID { get; set; }
        public string Resolution { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
        public IEnumerable<Cast> Casts { get; set; }
        public string SaleDateString => SaleDate.ToShortDateString();

        public static Anime FromDataRow(DataRow row)
        {
            return new Anime
            {
                ID = row.Field<int>(nameof(ID)),
                Name = row.Field<string>(nameof(Name)),
                Comment = row.Field<string>(nameof(Comment)),
                SaleDate = row.Field<DateTime>(nameof(SaleDate)),
                ProducerID = row.Field<int>(nameof(ProducerID)),
                Producer = row.Field<string>(nameof(Producer)),
                ResolutionID = row.Field<int>(nameof(ResolutionID)),
                Resolution = row.Field<string>(nameof(Resolution))
            };
        }

        public sealed class AnimeList : Neetsonic.DataStructure.BindingList<Anime>
        {
            public AnimeList() { }
            public AnimeList(IList<Anime> lst) : base(lst) { }

            protected override int Cmp(PropertyDescriptor property, ListSortDirection direction, Anime x, Anime y)
            {
                int flag = direction == ListSortDirection.Ascending ? 1 : -1;
                switch(property.Name)
                {
                    case @"Name":
                    {
                        return flag * FinalResult(CompareName(x, y), x, y);
                    }
                    case @"Producer":
                    {
                        return flag * FinalResult(string.Compare(x.Producer, y.Producer, StringComparison.CurrentCulture), x, y);
                    }
                    case @"Resolution":
                    {
                        return flag * FinalResult(new Resolution(x.Resolution) - new Resolution(y.Resolution), x, y);
                    }
                    case @"SaleDateString":
                    {
                        return flag * FinalResult(x.SaleDate.Date.Subtract(y.SaleDate.Date).Days, x, y);
                    }
                    default:
                    {
                        return 0;
                    }
                }
            }

            private static int CompareName(Anime x, Anime y)
            {
                return string.Compare(x.Name, y.Name, StringComparison.CurrentCulture);
            }
            private static int FinalResult(int ret, Anime x, Anime y)
            {
                return ret == 0 ? CompareName(x, y) : ret;
            }
        }
    }
}