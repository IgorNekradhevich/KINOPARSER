using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteParser
{
    class Film
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public Uri Image { get; set; }
        public string URL { get; set; }
        public Film( string name, string image, int year, string url)
        {
            Name = name;
            Image = new Uri(image);
            Year = year;
            URL = url;
        }



    }
}
