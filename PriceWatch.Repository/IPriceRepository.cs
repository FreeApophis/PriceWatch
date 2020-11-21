using System.Collections.Generic;

namespace PriceWatch.Repository
{
    public interface IPriceRepository
    {
        IEnumerable<Product> AllProducts();
    }
}