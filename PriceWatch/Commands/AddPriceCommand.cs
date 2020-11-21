using Funcky.Monads;

namespace PriceWatch.Commands
{
    internal class AddPriceCommand : ICliCommand
    {
        public string CommandKey => "A";

        public string Name => "Add new Product";

        public Option<int> Execute(string userInput)
        {
            throw new System.NotImplementedException();
        }
    }
}