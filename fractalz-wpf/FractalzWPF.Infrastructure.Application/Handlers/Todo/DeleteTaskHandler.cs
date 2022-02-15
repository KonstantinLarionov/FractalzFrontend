using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Todo;
using FractalzWPF.Application.Domains.Responses.Todo;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Todo
{
    public class DeleteTaskHandler : TodoBaseHandler
    {
        public DeleteTaskHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data) { }

        public DeleteTaskResponse Do(int idTask)
        {
            var request = new DeleteTaskRequest
            {
                IdTask = idTask
            };
            var response = _connector.Send<DeleteTaskResponse>(request, RequestType.DeleteTask, MyInfo.Token);
            return response;
        }
    }
}