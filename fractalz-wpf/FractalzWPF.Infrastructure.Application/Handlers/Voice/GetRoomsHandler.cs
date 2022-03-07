using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Voice;
using FractalzWPF.Application.Domains.Responses.Voice;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Voice
{
    public class GetRoomsHandler: BaseVoiceHandler
    {
        public GetRoomsHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }

        public GetRoomsResponse Do(int serveerId)
        {
            var request = new GetRoomsRequest()
            {
                ServerId = serveerId
            };
            var response = _connector.Send<GetRoomsResponse>(request, RequestType.GetRooms, MyInfo.Token);
            return response;
        }
    }
}