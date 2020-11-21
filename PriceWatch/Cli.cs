using System;
using System.Collections.Generic;
using Funcky.Extensions;
using PriceWatch.Commands;

namespace PriceWatch
{
    internal class Cli : ICli
    {
        public ICli Print(IEnumerable<ICliCommand> possibleCommands)
        {
            possibleCommands
                .ForEach(PrintCommand);

            return this;
        }

        private void PrintCommand(ICliCommand cliCommand)
        {
            Console.WriteLine($"[{cliCommand.CommandKey}] {cliCommand.Name}");
        }

        public string Read()
            => Console.ReadLine();

        public ICli Print(string message)
        {
            Console.WriteLine(message);

            return this;
        }

        public void Print(Product product)
        {
            Console.WriteLine(product.Name);
            product.Prices.ForEach(p => Console.WriteLine($"{p.ValidAt}: {p.Price}"));
        }
    }
}