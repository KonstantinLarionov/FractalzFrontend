using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Chat;
using FractalzWPF.Application.Domains.Responses.Chat;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Chat
{
    public class GetDialogsHandler : BaseChatHandler
    {        
        public GetDialogsHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data) { }
        public GetListDialogsResponse Do(int userId)
        {
            var request = new GetListDialogsRequest {UserId = userId};
            var response = _connector.Send<GetListDialogsResponse>(request, RequestType.GetListDialog, MyInfo.Token);
            return response;
        }
    }
}