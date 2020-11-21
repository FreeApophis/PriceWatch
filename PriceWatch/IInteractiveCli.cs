using Funcky.Monads;

namespace PriceWatch
{
    public interface IInteractiveCli
    {
        Option<int> NextCommand();
    }
}