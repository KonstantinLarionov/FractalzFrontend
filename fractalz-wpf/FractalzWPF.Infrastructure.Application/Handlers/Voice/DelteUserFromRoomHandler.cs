using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Voice;
using FractalzWPF.Application.Domains.Responses.Voice;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Voice
{
    public class DelteUserFromRoomHandler : BaseVoiceHandler
    {
        public DelteUserFromRoomHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }

        public DeleteUserFromRoomResponse Do(int userId, int roomId)
        {
            var request = new DeleteUserFromRoomRequest()
            {
                RoomId = roomId, UserId = userId
            };
            var response = _connector.Send<DeleteUserFromRoomResponse>(request, RequestType.DeleteUserFromRoom, MyInfo.Token);
            return response;
        }
    }
}