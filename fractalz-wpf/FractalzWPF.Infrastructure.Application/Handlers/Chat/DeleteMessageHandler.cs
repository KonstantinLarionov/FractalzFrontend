using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Chat;
using FractalzWPF.Application.Domains.Responses.Chat;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Chat
{
    public class DeleteMessageHandler : BaseChatHandler
    {
        public DeleteMessageHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data) { }

        public DeleteMessageResponse Do(int messageId)
        {
            var request = new DeleteMessageRequest
            {
                MessageId = messageId
            };
            var response = _connector.Send<DeleteMessageResponse>(request, RequestType.DeleteMessage, MyInfo.Token);
            return response;
        }
    }
}