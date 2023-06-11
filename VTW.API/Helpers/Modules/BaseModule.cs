using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace VTW.API.Helpers.Modules
{
    public class BaseModule : Autofac.Module
    {
        private readonly string assemblyName;
        private readonly string endsWith;

        public BaseModule(string assemblyName, string endsWith)
        {
            this.assemblyName = assemblyName;
            this.endsWith = endsWith;
        }

        protected override void Load(ContainerBuilder builder)
        {
            Assembly servicesAssembly = Assembly.Load(assemblyName);
            builder.RegisterAssemblyTypes(servicesAssembly)
                .Where(c => c.Name.EndsWith(endsWith))
                .AsImplementedInterfaces()
                .InstancePerRequest();
        }
    }
}
