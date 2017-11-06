using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string TrailerUrl { get; set; }
        public string ShortDescription { get; set; }
        public string Genre { get; set; }
        public string LongDescription { get; set; }
        public string Actors { get; set; }
        public string GetYoutubeId
        {
            get { return TrailerUrl.Substring(TrailerUrl.LastIndexOf("=") + 1); }
        }
    }
}
