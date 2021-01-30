using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteParser
{
    class Cutter
    {
       public string Text { get; set; }
        public Cutter (string text)
        {
            Text = text;
        }

        public string Cut( string begin, string end)
        {
            Text = Text.Remove(0, Text.IndexOf(begin) + begin.Length);
            return Cut(0, Text.IndexOf(end));
        }
        public string Cut(int begin, int end)
        {
            int len = Text.Length;
            if (begin < 0 || end < 0 || begin > end || end > len || begin > len)
                throw new Exception("Не верные параметры");

            string result = Text.Remove(end);
            result = result.Remove(0, begin);
            return result;
        }
    }
}
