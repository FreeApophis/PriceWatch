using System.Collections.Generic;
using PriceWatch.Commands;

namespace PriceWatch
{
    internal interface ICli
    {
        ICli Print(IEnumerable<ICliCommand> possibleCommands);
        ICli Print(string message);

        string Read();
        void Print(Product product);
    }
}