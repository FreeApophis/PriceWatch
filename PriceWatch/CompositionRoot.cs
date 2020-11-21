using System.Reflection;
using Autofac;
using PriceWatch.Commands;
using PriceWatch.Repository;

namespace PriceWatch
{
    internal class CompositionRoot
    {
        private readonly ContainerBuilder _builder = new ContainerBuilder();

        private CompositionRoot()
        {
        }

        public static CompositionRoot Create()
        {
            return new CompositionRoot();
        }

        public CompositionRoot RegisterServices()
        {
            _builder.RegisterType<Application>().As<IApplication>();
            _builder.RegisterType<TuttiScraper>().As<IPriceScraper>();
            _builder.RegisterType<InteractiveCli>().As<IInteractiveCli>();
            _builder.RegisterType<Cli>().As<ICli>();
            _builder.RegisterType<PriceRepository>().As<IPriceRepository>();

            return this;
        }

        public CompositionRoot RegistertCommands()
        {
            _builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => t.GetInterface(nameof(ICliCommand)) != null)
                .AsImplementedInterfaces();

            return this;
        }

        public IContainer Build()
        {
            return _builder.Build();
        }
    }
}
