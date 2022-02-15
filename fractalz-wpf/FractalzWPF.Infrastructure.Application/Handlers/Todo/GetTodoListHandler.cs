using System;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Todo;
using FractalzWPF.Application.Domains.Responses.Todo;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Todo
{
    public class GetTodoListHandler : TodoBaseHandler
    {
        public GetTodoListHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data) { }

        public GetTodoListResponse Do(int userId, DateTime from)
        {
            var request = new GetTodoListRequest
            {
                DateFrom = from,
                UserId = userId
            };
            var response = _connector.Send<GetTodoListResponse>(request, RequestType.GetTodoList,  MyInfo.Token);
            return response;
        }
    }
}