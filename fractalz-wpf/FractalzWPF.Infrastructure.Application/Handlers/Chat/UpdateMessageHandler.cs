using FractalzWPF.Application.Domains.Requests.Chat;
using FractalzWPF.Application.Domains.Responses.Chat;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;

namespace FractalzWPF.Infrastructure.Application.Handlers.Chat
{
    public class UpdateMessageHandler : BaseChatHandler
    {
        public UpdateMessageHandler(IFactoryConnector connectors) : base(connectors) { }

        public UpdateMessageResponse Do(int messageId, string text)
        {
            var request = new UpdateMessageRequest
            {
                MessagId = messageId,
                Text = text
            };
            var response = _connector.Send<UpdateMessageResponse>(request, RequestType.UpdateMessage);
            return response;
        }
    }
}