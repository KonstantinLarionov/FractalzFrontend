using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Chat;
using FractalzWPF.Application.Domains.Responses.Chat;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Chat
{
    public class CreateMessageHandler : BaseChatHandler
    {
        public CreateMessageHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data) { }

        public CreateMessageResponse Do(int userId, int dialogId, string message)
        {
            var request = new CreateMessageRequest
            {
                UserId = userId,
                DialogId = dialogId,
                Message = message
            };
            var response = _connector.Send<CreateMessageResponse>(request, RequestType.CreateMessage);
            return response;
        }
    }
}