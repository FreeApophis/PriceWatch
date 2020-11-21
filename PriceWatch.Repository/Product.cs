using System;
using System.Collections.Generic;

namespace PriceWatch
{
    public class Product
    {
        public Product(Uri source, string name)
        {
            SourceUri = source;
            Name = name;
        }

        public Uri SourceUri { get; }

        public string Name { get; }

        public List<PricePoint> Prices { get; }
    }
}