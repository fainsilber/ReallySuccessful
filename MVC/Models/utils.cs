using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public static class Util
    {
        //public string MyUtilMethod(int blah)
        public static string GetYoutubeId(string mTrailerUrl)
        {
            return mTrailerUrl.Substring(mTrailerUrl.LastIndexOf("=") + 1);
        }
    }
}
