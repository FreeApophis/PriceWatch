using Autofac;

namespace PriceWatch
{
    class Program
    {
        static int Main(string[] args)
        {
            using var rootContainer = CompositionRoot
                .Create()
                .RegisterServices()
                .RegistertCommands()
                .Build();

            // Autofac documentation advices to resolve from a lifetimescope instead of the root container
            using var programLifetime = rootContainer.BeginLifetimeScope();

            return programLifetime
                .Resolve<IApplication>()
                .Run();
        }
    }
}
