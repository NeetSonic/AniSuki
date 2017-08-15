using System;
using System.ComponentModel;
using System.IO;

namespace AniSuki.Model
{
    public class AnimeFile
    {
        public AnimeFile(string filePath) => FilePath = filePath;

        private string _rename;

        public string FilePath { get; set; }
        public string Name => Path.GetFileName(FilePath);
        public string Rename
        {
            get => _rename ?? Name;
            set => _rename = value;
        }

        public AnimeFile ShollowClone() => (AnimeFile)MemberwiseClone();
    }

    public sealed class AnimeFileList : Neetsonic.DataStructure.BindingList<AnimeFile>
    {
        protected override int Cmp(PropertyDescriptor property, ListSortDirection direction, AnimeFile x, AnimeFile y)
        {
            int flag = direction == ListSortDirection.Ascending ? 1 : -1;
            return flag * string.Compare(x.Rename, y.Rename, StringComparison.CurrentCulture);
        }
    }
}