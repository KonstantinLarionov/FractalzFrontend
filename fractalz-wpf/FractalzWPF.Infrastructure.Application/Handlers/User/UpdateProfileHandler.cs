using System;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Chat;
using FractalzWPF.Application.Domains.Requests.User;
using FractalzWPF.Application.Domains.Responses.User;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.User
{
    public class UpdateProfileHandler
    {
        private readonly IConnector _connector;
        private readonly UserData _myInfo;
        public UpdateProfileHandler(IFactoryConnector connectors, IOptions<UserData> userData)
        {
            _myInfo = userData.Value ?? throw new ArgumentException(nameof(userData));
            _connector = connectors.Get(ConnectorType.User);
        }

        public UpdateProfileResponse Do(int userId, string login, string name, string surname, string patro, string number, string email)
        {
            var request = new UpdateProfileRequest
            {
                UserId = userId, Login = login, Name = name, Surname = surname, Patro = patro, Number = number, Email = email
            };
            var response = _connector.Send<UpdateProfileResponse>(request, RequestType.UpdateProfile, _myInfo.Token);
            return response;
        }
    }
}