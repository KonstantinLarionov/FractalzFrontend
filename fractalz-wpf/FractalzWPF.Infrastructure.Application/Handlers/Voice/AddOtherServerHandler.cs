using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Voice;
using FractalzWPF.Application.Domains.Responses.Voice;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Voice
{
    public class AddOtherServerHandler : BaseVoiceHandler
    {
        public AddOtherServerHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }

        public AddOtherServerResponse Do(int serverId, int userId)
        {
            var request = new AddOtherServerRequest()
            {
                ServerId = serverId,
                UserId = userId
            };
            var response = _connector.Send<AddOtherServerResponse>(request, RequestType.AddOtherServer, MyInfo.Token);
            
            return response;
        }
    }
}