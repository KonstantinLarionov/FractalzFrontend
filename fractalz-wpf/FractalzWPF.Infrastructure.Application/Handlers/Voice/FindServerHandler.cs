using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Voice;
using FractalzWPF.Application.Domains.Responses.Voice;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Voice
{
    public class FindServerHandler: BaseVoiceHandler
    {
        public FindServerHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }

        public FindServerResponse Do(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return new FindServerResponse() {Success = false, Message = "Имя не может быть пустым"};
            }

            var request = new FindServerRequest()
            {
                Name = name
            };
            var response = _connector.Send<FindServerResponse>(request, RequestType.FindOtherServer, MyInfo.Token);
            return response;
        }
    }
}