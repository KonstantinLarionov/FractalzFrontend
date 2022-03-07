using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Voice;
using FractalzWPF.Application.Domains.Responses.Voice;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Voice
{
    public class InsertUserInRoomHandler: BaseVoiceHandler
    {
        public InsertUserInRoomHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }

        public InsertUserInRoomResponse Do(int roomId, int userId)
        {
            var request = new InsertUserInRoomRequest()
            { 
                RoomId = roomId, UserId = userId
            };
            var response = _connector.Send<InsertUserInRoomResponse>(request, RequestType.InsertUserInRoom, MyInfo.Token);
            return response;
        }
    }
}
