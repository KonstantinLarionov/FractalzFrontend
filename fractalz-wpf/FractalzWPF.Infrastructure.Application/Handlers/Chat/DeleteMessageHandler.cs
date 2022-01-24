using FractalzWPF.Application.Domains.Requests.Chat;
using FractalzWPF.Application.Domains.Responses.Chat;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;

namespace FractalzWPF.Infrastructure.Application.Handlers.Chat
{
    public class DeleteMessageHandler : BaseChatHandler
    {
        public DeleteMessageHandler(IFactoryConnector connectors) : base(connectors) { }

        public DeleteMessageResponse Do(int messageId)
        {
            var request = new DeleteMessageRequest
            {
                MessageId = messageId
            };
            var response = _connector.Send<DeleteMessageResponse>(request, RequestType.DeleteMessage);
            return response;
        }
    }
}