using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Voice;
using FractalzWPF.Application.Domains.Responses.Voice;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Voice
{
    public class EditRoomHandler: BaseVoiceHandler
    {
        public EditRoomHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }

        public EditRoomResponse Do(string name, int roomId)
        {
            if (string.IsNullOrEmpty(name))
            {
                return new EditRoomResponse() {Success = false, Message = "Имя не может быть пустым"};
            }

            var request = new EditRoomRequest()
            {
                NameRoom = name, RoomId = roomId
            };
            var response = _connector.Send<EditRoomResponse>(request, RequestType.EditRoom, MyInfo.Token);
            return response;
        }
    }
}