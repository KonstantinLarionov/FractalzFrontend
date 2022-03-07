using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Voice;
using FractalzWPF.Application.Domains.Responses.Voice;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using FractalzWPF.Infrastructure.Application.Handlers.Todo;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Voice
{
    public class CreateMyServerHandler : BaseVoiceHandler
    {
        public CreateMyServerHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }

        public CreateMyServerResponse Do(string name, int userId)
        {
            if (string.IsNullOrEmpty(name))
            {
                return new CreateMyServerResponse() {Success = false, Message = "Имя не может быть пустым"};
            }

            var request = new CreateMyServerRequest()
            {
                NameServer = name,
                UserId = userId
            };
            var response = _connector.Send<CreateMyServerResponse>(request, RequestType.CreateMyServer, MyInfo.Token);
            return response;
        }
    }
}