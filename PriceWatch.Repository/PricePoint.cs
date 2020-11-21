using System;
using Funcky.Monads;

namespace PriceWatch
{
    public class PricePoint
    {
        public PricePoint(Money price, Option<DateTime> validAt = default)
        {
            Price = price;
            ValidAt = validAt.GetOrElse(DateTime.Now);
        }
        public DateTime ValidAt { get; }
        public Money Price { get; }
    }
}