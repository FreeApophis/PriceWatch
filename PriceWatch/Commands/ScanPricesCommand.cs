using Funcky.Extensions;
using Funcky.Monads;
using PriceWatch.Repository;

namespace PriceWatch.Commands
{
    internal class ScanPricesCommand : ICliCommand
    {
        private readonly ICli _cli;
        private readonly IPriceRepository _priceRepository;

        public ScanPricesCommand(ICli cli, IPriceRepository priceRepository)
        {
            _cli = cli;
            _priceRepository = priceRepository;
        }

        public string CommandKey => "S";

        public string Name => "Scan prices";

        public Option<int> Execute(string userInput)
        {
            _priceRepository
                .AllProducts()
                .ForEach(p => _cli.Print(p));

            return Option<int>.None();
        }
    }
}