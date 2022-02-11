using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Chat
{
    public class BaseChatHandler
    {
        protected readonly IConnector _connector;     
        protected readonly UserData MyInfo;

        public BaseChatHandler(IFactoryConnector connectors, IOptions<UserData> data)
        {
            _connector = connectors.Get(ConnectorType.Chat);
            MyInfo = data.Value;
        }

    }
}