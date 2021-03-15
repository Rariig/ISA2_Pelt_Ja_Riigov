using System;
using System.IO;
using System.Net;

namespace MyCodeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
           return GetWebpage(url);
        }

        public string ScrapeWebpage (string url, string filePath)
        {
            string reply = GetWebpage(url);
            File.WriteAllText(filePath,reply);

            return reply;
        }

        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            string content = client.DownloadString(url);
            content += "That's all!";
            return content;
        }
    }
}
