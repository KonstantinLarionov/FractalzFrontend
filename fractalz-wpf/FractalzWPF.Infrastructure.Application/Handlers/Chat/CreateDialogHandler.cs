using System.Collections.Generic;
using FractalzWPF.Application.Domains.Requests.Chat;
using FractalzWPF.Application.Domains.Responses.Chat;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;

namespace FractalzWPF.Infrastructure.Application.Handlers.Chat
{
    public class CreateDialogHandler : BaseChatHandler
    {
        public CreateDialogHandler(IFactoryConnector connectors) : base(connectors) { }

        public CreateDialogResponse Do(List<int> usersId)
        {
            var request = new CreateDialogRequest
            {
                UsersId = usersId
            };
            var response = _connector.Send<CreateDialogResponse>(request, RequestType.CreateDialog);
            return response;
        }
    }
}