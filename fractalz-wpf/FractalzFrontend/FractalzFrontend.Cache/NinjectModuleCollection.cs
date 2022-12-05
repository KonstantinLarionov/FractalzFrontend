using FractalzFrontend.Application.Abstractions;

using Ninject;
using Ninject.Modules;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzFrontend.Cache
{
    public class NinjectModuleCacheCollection
    {
        public NinjectModuleCacheCollection() 
        {
            AddCacheCollection();
        }

        public IKernel Services = new StandardKernel();
        private void AddCacheCollection()
        {
            Services.Bind<ICacheController>().To<CacheCreator>().InSingletonScope();
        }

    }
}
