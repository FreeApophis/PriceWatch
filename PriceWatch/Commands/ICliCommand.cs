using Funcky.Monads;

namespace PriceWatch.Commands
{
    public interface ICliCommand
    {
        string CommandKey { get; }
        string Name { get; }

        Option<int> Execute(string userInput);
    }
}