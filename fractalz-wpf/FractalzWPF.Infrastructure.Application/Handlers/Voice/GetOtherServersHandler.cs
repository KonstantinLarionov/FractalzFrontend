using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Voice;
using FractalzWPF.Application.Domains.Responses.Voice;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Voice
{
    public class GetOtherServersHandler : BaseVoiceHandler
    {
        public GetOtherServersHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }

        public GetOtherServersResponse Do(int userId)
        {
            var request = new GetOtherServersRequest()
            {
                UserId = userId
            };
            var response = _connector.Send<GetOtherServersResponse>(request, RequestType.GetOtherServers, MyInfo.Token);
            return response;
        }
    }
}