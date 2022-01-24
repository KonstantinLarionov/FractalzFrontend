using System;
using FractalzWPF.Application.Domains.Requests.Todo;
using FractalzWPF.Application.Domains.Responses.Todo;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;

namespace FractalzWPF.Infrastructure.Application.Handlers.Todo
{
    public class GetTodoListHandler : TodoBaseHandler
    {
        public GetTodoListHandler(IFactoryConnector connectors) : base(connectors) { }

        public GetTodoListResponse Do(int userId, DateTime from)
        {
            var request = new GetTodoListRequest
            {
                DateFrom = from,
                UserId = userId
            };
            var response = _connector.Send<GetTodoListResponse>(request, RequestType.GetTodoList);
            return response;
        }
    }
}