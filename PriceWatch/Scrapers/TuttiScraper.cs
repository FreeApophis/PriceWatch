using System;
using System.Linq;
using Funcky.Extensions;
using HtmlAgilityPack;

namespace PriceWatch
{
    internal class TuttiScraper : IPriceScraper
    {
        public TuttiScraper()
        {
        }

        public Product Scrape(Uri uri)
        {
            var web = new HtmlAgilityPack.HtmlWeb();
            HtmlDocument doc = web.Load(uri);

            var x = ExtractPrice(doc);
            return new Product(uri, ExtractName(doc));
        }

        private static int ExtractPrice(HtmlDocument doc)
        {
            return ParsePrice(doc.DocumentNode.SelectNodes("//dd").Skip(1).First().InnerText);
        }

        private static int ParsePrice(string price)
        {
            return price
                .Replace("&#x27;", string.Empty)
                .Replace(".-", string.Empty)
                .TryParseInt()
                .GetOrElse(() => throw new NotImplementedException());
        }

        private static string ExtractName(HtmlDocument doc)
        {
            return doc.DocumentNode.SelectNodes("//h1").First().InnerText;
        }
    }
}