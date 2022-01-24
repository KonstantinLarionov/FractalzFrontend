using FractalzWPF.Application.Domains.Requests.Chat;
using FractalzWPF.Application.Domains.Responses.Chat;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;

namespace FractalzWPF.Infrastructure.Application.Handlers.Chat
{
    public class CreateMessageHandler : BaseChatHandler
    {
        public CreateMessageHandler(IFactoryConnector connectors) : base(connectors) { }

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