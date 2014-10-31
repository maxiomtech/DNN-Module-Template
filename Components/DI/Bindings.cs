using System.Reflection;
using Autofac;

namespace CompanyName.ModuleName.Components.DI
{
    [assembly: WebActivatorEx.PreApplicationStartMethod(typeof(CompanyName.ModuleName.Components.DI.Bindings), "RegisterServices")]
    public class Bindings
    {

        public static IContainer Container { get; set; }


        public static void RegisterServices()
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where((x) => x.Name.EndsWith("Repository"))
                .AsImplementedInterfaces();

            Container = builder.Build();
        }

    }
}