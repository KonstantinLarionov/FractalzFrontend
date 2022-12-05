using FractalzFrontend.Application.Abstractions;
using FractalzFrontend.Models;
using Ninject;

namespace FractalzFrontend.Views
{
    public class LayoutModel
    {
        private ICacheController _cacheController;

        public LayoutModel(ICacheController cacheController)
        {
            _cacheController = NinjectCollection
                .Cache
                .Services
                .Get<ICacheController>();
        }

        public void ClearCache()
        {
            _cacheController.ClearCache();
        }
    }
}