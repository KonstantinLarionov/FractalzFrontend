using System.Collections.Generic;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Chat;
using FractalzWPF.Application.Domains.Responses.Chat;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Chat
{
    public class CreateDialogHandler : BaseChatHandler
    {
        public CreateDialogHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data) { }

        public CreateDialogResponse Do(List<int> usersId)
        {
            var request = new CreateDialogRequest
            {
                UsersId = usersId
            };
            var response = _connector.Send<CreateDialogResponse>(request, RequestType.CreateDialog, MyInfo.Token);
            return response;
        }
    }
}