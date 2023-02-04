using FractalzFrontend.Application.Abstractions;

using Ninject;
using Ninject.Modules;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzFrontend.Client
{
    public class NinjectModuleClientCollection
    {
        public NinjectModuleClientCollection() 
        {
            AddClientCollection();
        }

        public IKernel Services = new StandardKernel();
        public void AddClientCollection()
        {
            Services.Bind<IRestClient>().To<RestApiClient>().InSingletonScope();
            Services.Bind<IWebSocketClient>().To<WebsocketClient>().InSingletonScope();
        }
    }
}
