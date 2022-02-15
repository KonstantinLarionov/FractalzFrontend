using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Chat;
using FractalzWPF.Application.Domains.Responses.Chat;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Chat
{
    public class DeleteDialogHandler : BaseChatHandler
    {
        public DeleteDialogHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data) { }

        public DeleteDialogResponse Do(int dialogId)
        {
            var request = new DeleteDialogRequest
            {
                DialogId = dialogId
            };
            var response = _connector.Send<DeleteDialogResponse>(request, RequestType.DeleteDialog, MyInfo.Token);
            return response;
        }
    }
}