using System;
using System.Collections.Generic;

namespace PriceWatch.Repository
{
    public class PriceRepository : IPriceRepository
    {
        private readonly List<Product> _products = new List<Product>();

        public PriceRepository()
        {
        }

        public IEnumerable<Product> AllProducts()
        {
            return _products;
        }

        public void AddProdcut(Product product)
        {
            _products.Add(product);
        }
    }
}
