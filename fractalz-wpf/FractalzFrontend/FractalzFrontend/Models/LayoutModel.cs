using Fractalz.Application.Domains.Entities.Profile;

using FractalzFrontend.Application.Abstractions;
using FractalzFrontend.Models;
using Ninject;

using System.Net.Sockets;

namespace FractalzFrontend.Models
{
    public class LayoutModel
    {
        private ICacheController _cacheController;
        private IWebSocketClient _socket;
        private ILogDispatcher _log;

        public LayoutModel()
        {
            _cacheController = NinjectCollection
                .Cache
                .Services
                .Get<ICacheController>();
            _socket = NinjectCollection
                .Integration
                .Services
                .Get<IWebSocketClient>();
            _log = NinjectCollection
                .Logger
                .Services
                .Get<ILogDispatcher>();

            _socket.SetLogger(_log);
            _socket.Connect(_cacheController.GetCache<User>("User_Info").Id.ToString());

            _socket.OnUsers += _socket_OnUsers;
            _socket.OnDialogs += _socket_OnDialogs;
        }

        private void _socket_OnDialogs(Fractalz.Application.Domains.MappingEntities.Chat.DialogsMappedDto message)
        {
            throw new System.NotImplementedException();
        }

        private void _socket_OnUsers(Fractalz.Application.Domains.Entities.Profile.User message)
        {
            throw new System.NotImplementedException();
        }

        public void ClearCache()
        {
            _cacheController.ClearCache();
        }
    }
}