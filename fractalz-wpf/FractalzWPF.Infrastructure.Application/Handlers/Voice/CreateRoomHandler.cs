using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Voice;
using FractalzWPF.Application.Domains.Responses.Voice;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Voice
{
    public class CreateRoomHandler : BaseVoiceHandler
    {
        public CreateRoomHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }

        public CreateRoomResponse Do(string name, int serverId)
        {
            if (string.IsNullOrEmpty(name))
            {
                return new CreateRoomResponse() {Success = false, Message = "Имя не может быть пустым"};
            }

            var request = new CreateRoomRequest()
            {
                Name = name, ServerId = serverId
            };
            var response = _connector.Send<CreateRoomResponse>(request, RequestType.CreateRoom, MyInfo.Token);
            return response;
        }
    }
}