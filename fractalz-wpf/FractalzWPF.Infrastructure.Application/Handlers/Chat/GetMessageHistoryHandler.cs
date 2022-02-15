using System;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Chat;
using FractalzWPF.Application.Domains.Responses.Chat;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Chat
{
    public class GetMessageHistoryHandler : BaseChatHandler
    {
        public GetMessageHistoryHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data) { }
        
        public GetMessageHistoryResponse Do(int dialogId, DateTime from, int Count)
        {
            var request = new GetMessageHistoryRequest
            {
                IdDialog = dialogId,
                DateFrom = from,
                CountMessage = Count
            };
            var result = _connector.Send<GetMessageHistoryResponse>(request, RequestType.GetMessageHistory);
            return result;
        }

    }
}