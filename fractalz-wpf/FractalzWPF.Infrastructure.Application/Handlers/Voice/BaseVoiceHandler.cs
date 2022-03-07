using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Voice
{
    public class BaseVoiceHandler
    {
        protected readonly IConnector _connector;
        protected readonly UserData MyInfo;
        public BaseVoiceHandler(IFactoryConnector connectors, IOptions<UserData> data)
        {
            _connector = connectors.Get(ConnectorType.Voice);
            MyInfo = data.Value;
        }

    }
}