using System;
using System.Collections.Generic;
using System.Linq;
using Funcky.Extensions;
using Funcky.Monads;
using PriceWatch.Commands;

namespace PriceWatch
{
    internal class InteractiveCli : IInteractiveCli
    {
        readonly private IEnumerable<ICliCommand> _possibleCommands;
        readonly private ICli _cli;

        public InteractiveCli(ICli cli, IEnumerable<ICliCommand> possibleCommands)
        {
            _cli = cli;
            _possibleCommands = possibleCommands;
        }

        public Option<int> NextCommand() 
            => Process(_cli.Print(_possibleCommands).Read());

        private Option<int> Process(string userInput) 
            => _possibleCommands
                .Where(c => userInput.StartsWith(c.CommandKey, StringComparison.InvariantCultureIgnoreCase))
                .FirstOrNone()
                .AndThen(c => c.Execute(userInput));
    }
}