using FractalzFrontend.Application.Abstractions;

using Ninject;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzFrontend.Logger
{
    public class NinjectLogClientCollection
    {
        public NinjectLogClientCollection()
        {
            AddClientCollection();
        }

        public IKernel Services = new StandardKernel();
        public void AddClientCollection()
        {
            Services.Bind<ILogDispatcher>().To<LogDispatcher>().InSingletonScope();
        }
    }
}
