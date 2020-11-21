namespace PriceWatch
{
    internal class Application : IApplication
    {
        private readonly IInteractiveCli _interactiveCli;

        public Application(IInteractiveCli interactiveCli)
        {
            _interactiveCli = interactiveCli;
        }

        public int Run() 
            => Funcky
            .Functional
            .Retry(_interactiveCli.NextCommand);
    }
}
