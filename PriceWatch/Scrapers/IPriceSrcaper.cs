using System;
using System.Collections.Generic;
using System.Text;

namespace PriceWatch
{
    interface IPriceScraper
    {
        Product Scrape(Uri uri);
    }
}
