using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Todo;
using FractalzWPF.Application.Domains.Responses.Todo;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Todo
{
    public class UpdateStatusTaskHandler : TodoBaseHandler
    {
        public UpdateStatusTaskHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data) { }

        public UpdateStatusTaskResponse Do(int idTask, bool completed)
        {
            var request = new UpdateStatusTaskRequest
            {
                IdTask = idTask,
                Completed = completed
            };
            var response = _connector.Send<UpdateStatusTaskResponse>(request, RequestType.UpdateStatusTask, MyInfo.Token);
            return response;
        }
    }
}