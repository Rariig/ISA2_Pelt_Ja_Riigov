using System;
using MyCodeLibrary;

namespace Kordamine_Bob_References
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebpage("http://google.com");
            Console.WriteLine(value);

            Console.ReadLine();
        }
    }
}
