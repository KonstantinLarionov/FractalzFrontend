using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Voice;
using FractalzWPF.Application.Domains.Responses.Voice;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Voice
{
    public class GetMyServersHandler : BaseVoiceHandler
    {
        public GetMyServersHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }

        public GetMyServersResponse Do(int userId)
        {
            var request = new GetMyServersRequest()
            {
                UserId = userId
            };
            var response = _connector.Send<GetMyServersResponse>(request, RequestType.GetMyServers, MyInfo.Token);
            return response;
        }
    }
}