using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Todo
{
    public class TodoBaseHandler
    {
        protected readonly IConnector _connector;
        protected readonly UserData MyInfo;
        public TodoBaseHandler(IFactoryConnector connectors, IOptions<UserData> data)
        {
            _connector = connectors.Get(ConnectorType.Todo);
            MyInfo = data.Value;
        }

    }
}