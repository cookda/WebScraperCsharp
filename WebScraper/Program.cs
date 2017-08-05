using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://www.glassdoor.com/Job/jobs.htm?suggestCount=0&suggestChosen=false&clickSource=searchBtn&typedKeyword=entry%20level%20software%20engineer&sc.keyword=entry%20level%20software%20engineer&locT=&locId=&jobType=&jl=2474142853");
            var HeaderNames = doc.DocumentNode.SelectNodes("//a[@class='jobLink']").ToList();
            foreach (var item in HeaderNames)
            {
                Console.WriteLine(item.InnerText);
            }

        }
    }
}
