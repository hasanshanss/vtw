using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace VTW.API.Helpers.Modules
{
    public class ServicesModule : BaseModule
    {
        public ServicesModule() : base(AssemblyNames.Services, "Service")
        {
        }
    }
}
