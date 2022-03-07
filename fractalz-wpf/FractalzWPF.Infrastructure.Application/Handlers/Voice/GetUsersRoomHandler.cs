using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Voice;
using FractalzWPF.Application.Domains.Responses.Voice;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Voice
{
    public class GetUsersRoomHandler: BaseVoiceHandler
    {
        public GetUsersRoomHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }

        public GetUsersRoomResponse Do(int roomId)
        {
            var request = new GetUsersRoomRequest()
            { 
                RoomId = roomId
            };
            var response = _connector.Send<GetUsersRoomResponse>(request, RequestType.GetUsersRoom, MyInfo.Token);
            return response;
        }
    }
}