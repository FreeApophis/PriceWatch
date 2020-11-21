using Funcky.Monads;

namespace PriceWatch.Commands
{
    internal class QuitCommand : ICliCommand
    {
        readonly private ICli _cli;
        private const int Success = 0;

        public QuitCommand(ICli cli)
        {
            _cli = cli;
        }

        public string CommandKey => "Q";

        public string Name => "Quit";

        Option<int> ICliCommand.Execute(string userInput)
        {
            _cli.Print("Goodbye!");
            
            return Option.Some(Success);
        }
    }
}