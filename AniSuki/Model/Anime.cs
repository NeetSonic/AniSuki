using System;

namespace AniSuki.Model
{
    public sealed class Anime
    {
        public int ID{ get; set; }
        public string Name{ get; set; }
        public string Comment{ get; set; }
        public DateTime SaleDate{ get; set; }
        public int ProducerID{ get; set; }
        public string Producer{ get; set; }
        public int ResolutionID{ get; set; }
        public string Resolution{ get; set; }
    }
}