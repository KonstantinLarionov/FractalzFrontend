using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;

namespace FractalzWPF.Infrastructure.Application.Handlers.Todo
{
    public class TodoBaseHandler
    {
        protected readonly IConnector _connector;
        public TodoBaseHandler(IFactoryConnector connectors)
        {
            _connector = connectors.Get(ConnectorType.Todo);
        }

    }
}