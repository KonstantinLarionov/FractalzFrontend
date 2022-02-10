using System;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Todo;
using FractalzWPF.Application.Domains.Responses.Todo;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Todo
{
    public class CreateTaskHandler : TodoBaseHandler
    {
        public CreateTaskHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data) { }

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
            var response = _connector.Send<CreateTaskResponse>(request, RequestType.CreateTask, MyInfo.Token);
            return response;
        }
    }
}