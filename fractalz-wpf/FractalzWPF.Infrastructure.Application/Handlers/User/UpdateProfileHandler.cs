using System;
using FractalzWPF.Application.Domains.Requests.Chat;
using FractalzWPF.Application.Domains.Requests.User;
using FractalzWPF.Application.Domains.Responses.User;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;

namespace FractalzWPF.Infrastructure.Application.Handlers.User
{
    public class UpdateProfileHandler
    {
        private readonly IConnector _connector;
        public UpdateProfileHandler(IFactoryConnector connectors)
        {
            _connector = connectors.Get(ConnectorType.User);
        }

        public UpdateProfileResponse Do(int userId, string login, string name, string surname, string patro, string number, string email)
        {
            var request = new UpdateProfileRequest
            {
                UserId = userId, Login = login, Name = name, Surname = surname, Patro = patro, Number = number, Email = email
            };
            var response = _connector.Send<UpdateProfileResponse>(request, RequestType.UpdateProfile);
            return response;
        }
    }
}