using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp322.Shared.Models
{
    public class ShowsInfo
    {
        public DateTime lastUpdated { get; set; }
        public List<Show> shows { get; set; }
    }

    public class Show
    {
        public string id { get; set; }
        //public int eventIdBts { get; set; }
        public DateTime addedDate { get; set; }
        public Boolean isSoldOut { get; set; }
        public Boolean isCancelled { get; set; }

        public DateTime onSaleDate { get; set; }
        public string priceText { get; set; }
        public DateTime date { get; set; }
        public string venue { get; set; }

        public List<Artist> artists { get; set; }
        public string notes { get; set; }
        public string detailsUri { get; set; }
        public string artistsText { get; set; }
    }

    public class Artist
    {
        public string name { get; set; }
        public string stageTime { get; set; }
        public string videoUrl { get; set; }
        public string id { get; set; }
    }

    public class VenueBts
    {
        public string name { get; set; }
        public string nameRaw { get; set; }
        public string id { get; set; }
    }
}
