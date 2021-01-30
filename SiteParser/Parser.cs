using System.Net;
using System.IO;

namespace SiteParser
{
    class Parser
    {
        string _url;
        public string Site { get; protected set; }
        public Parser(string url)
        {
            _url = url;
            Refresh();
        }

        public void Refresh()
        {
            WebRequest request = WebRequest.Create(_url);
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            Site = reader.ReadToEnd();
        }

    }
}
