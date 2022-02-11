using System;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.User;
using FractalzWPF.Application.Domains.Responses.User;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.User
{
    public class LoginHandler
    {
        private readonly IConnector _connector;
        private readonly IFactoryConnector _factoryConnector;
        private readonly ILinkedEventService _linkedEventService;
        private IOptions<UserData> _myInfo;
        public LoginHandler(IFactoryConnector factoryConnector, ILinkedEventService linkedEventService, IOptions<UserData> userData)
        {
            _myInfo = userData;
            _factoryConnector = factoryConnector;
            _connector = factoryConnector.Get(ConnectorType.User);
            _linkedEventService = linkedEventService ?? throw new ArgumentException(nameof(linkedEventService));
        }

        public LoginResponse Do(string login, string password)
        {
            var request = new LoginRequest()
            {
                Login = login,
                Password = password
            };
            var response = _connector.Send<LoginResponse>(request, RequestType.Login);

            if (response.Success)
            {
                _myInfo.Value.Token = _factoryConnector.GetToken(login, password);
                _myInfo.Value.Id = response.User.Id;
                _linkedEventService.ConnectDefaultEvent();
            }

            return response;
        }
    }
}