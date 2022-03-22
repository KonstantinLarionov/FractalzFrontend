using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Conference
{
    public class ConferenceBaseHandler
    {
        protected readonly IConnector _connector;
        protected readonly UserData MyInfo;
        public ConferenceBaseHandler(IFactoryConnector connectors, IOptions<UserData> data)
        {
            _connector = connectors.Get(ConnectorType.Conference);
            MyInfo = data.Value;
        }
    }
}