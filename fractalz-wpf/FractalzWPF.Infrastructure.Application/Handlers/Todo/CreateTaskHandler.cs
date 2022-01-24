using System;
using FractalzWPF.Application.Domains.Requests.Todo;
using FractalzWPF.Application.Domains.Responses.Todo;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;

namespace FractalzWPF.Infrastructure.Application.Handlers.Todo
{
    public class CreateTaskHandler : TodoBaseHandler
    {
        public CreateTaskHandler(IFactoryConnector connectors) : base(connectors) { }

        public CreateTaskResponse Do(int todoListId, string header, string about, DateTime timeStart, int durationInMinute)
        {
            var request = new CreateTaskRequest
            {
                TodoListId = todoListId,
                Header = header,
                About = about,
                TimeStart = timeStart,
                DurationInMinute = durationInMinute,
            };
            var response = _connector.Send<CreateTaskResponse>(request, RequestType.CreateTask);
            return response;
        }
    }
}