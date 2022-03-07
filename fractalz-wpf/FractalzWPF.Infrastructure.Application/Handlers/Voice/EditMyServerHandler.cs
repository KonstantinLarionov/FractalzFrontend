using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Voice;
using FractalzWPF.Application.Domains.Responses.Voice;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Voice
{
    public class EditMyServerHandler: BaseVoiceHandler
    {
        public EditMyServerHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }

        public EditMyServerResponse Do(string name, int serverId)
        {
            if (string.IsNullOrEmpty(name))
            {
                return new EditMyServerResponse() {Success = false, Message = "Имя не может быть пустым"};
            }

            var request = new EditMyServerRequest()
            {
                NameServer = name, ServerId = serverId
            };
            var response = _connector.Send<EditMyServerResponse>(request, RequestType.EditMyServer, MyInfo.Token);
            return response;
        }
    }
}