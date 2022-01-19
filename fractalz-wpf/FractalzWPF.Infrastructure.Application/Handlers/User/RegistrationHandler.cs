using System;
using FractalzWPF.Application.Domains.Requests.User;
using FractalzWPF.Application.Domains.Responses.User;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Objects = FractalzWPF.Application.Domains.Entities;

namespace FractalzWPF.Infrastructure.Application.Handlers.User
{
    public class RegistrationHandler
    {
        private readonly IFactoryConnector _connectors;
        private readonly IConnector _connector;
        public RegistrationHandler(IFactoryConnector connector)
        {
            _connectors = connector ?? throw new ArgumentException(nameof(connector));
            _connector = _connectors.Get(ConnectorType.User);
        }

        public RegistrationResponse Do(string login, string email, string password)
        {
            var request = new RegistrationRequest()
            { Email = email, Login = login, Password = password };
            var response = _connector.Send<RegistrationResponse>(request, RequestType.Reg);
            return response;
        }
    }
}