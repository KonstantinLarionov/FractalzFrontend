using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;

namespace FractalzWPF.Infrastructure.Application.Handlers.Chat
{
    public class BaseChatHandler
    {
        protected readonly IConnector _connector;
        public BaseChatHandler(IFactoryConnector connectors)
        {
            _connector = connectors.Get(ConnectorType.Chat);
        }

    }
}