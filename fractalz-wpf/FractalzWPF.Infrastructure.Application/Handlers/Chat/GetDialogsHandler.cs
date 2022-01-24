using FractalzWPF.Application.Domains.Requests.Chat;
using FractalzWPF.Application.Domains.Responses.Chat;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;

namespace FractalzWPF.Infrastructure.Application.Handlers.Chat
{
    public class GetDialogsHandler : BaseChatHandler
    {        
        public GetDialogsHandler(IFactoryConnector connectors) : base(connectors) { }
        public GetListDialogsResponse Do(int userId)
        {
            var request = new GetListDialogsRequest {UserId = userId};
            var response = _connector.Send<GetListDialogsResponse>(request, RequestType.GetListDialog);
            return response;
        }
    }
}