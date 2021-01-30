using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SiteParser
{
    class CutTheFilms:Cutter
    {
        List<Film> films;
        public CutTheFilms(string site) : base(site) 
        {
            films = new List<Film>();
        }

        public List<Film> GetFilms()
        {
            films.Clear();
            string testResult = Cut("Скорее", "/body");
            Text = testResult;
            testResult = Cut("pic", "Правая");// \"-->" 
            Text = testResult;
            string img = Cut("title=\"", "jpg");
            img = "https://www.kinopoisk.ru" + img + "jpg";

            Console.WriteLine(img);
            return films;
        }

    }
}
