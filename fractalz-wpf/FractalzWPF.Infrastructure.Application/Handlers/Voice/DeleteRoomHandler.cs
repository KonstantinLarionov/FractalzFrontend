using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Voice;
using FractalzWPF.Application.Domains.Responses.Voice;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Voice
{
    public class DeleteRoomHandler : BaseVoiceHandler
    {
        public DeleteRoomHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }

        public DeleteRoomResponse Do(int serverId, int roomId)
        {
            var request = new DeleteRoomRequest()
            {
                ServerId = serverId, RoomId = roomId
            };
            var response = _connector.Send<DeleteRoomResponse>(request, RequestType.DeleteRoom, MyInfo.Token);
            return response;
        }
    }
}