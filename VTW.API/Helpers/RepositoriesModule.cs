using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace VTW.API.Helpers
{
    public class RepositoriesModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            Assembly servicesAssembly = Assembly.Load("VTW.DAL");
            builder.RegisterAssemblyTypes(servicesAssembly)
                .Where(c => c.Name.EndsWith("Repository"))
                .AsImplementedInterfaces();
        }
    }
}
