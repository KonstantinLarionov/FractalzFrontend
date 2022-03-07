using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Voice;
using FractalzWPF.Application.Domains.Responses.Voice;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Voice
{
    public class DeleteMyServerHandler: BaseVoiceHandler
    {
        public DeleteMyServerHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }

        public DeleteMyServerResponse Do(int serverId)
        {
            var request = new DeleteMyServerRequest()
            {
                ServerId = serverId
            };
            var response = _connector.Send<DeleteMyServerResponse>(request, RequestType.DeleteMyServer, MyInfo.Token);
            return response;
        }
    }
}