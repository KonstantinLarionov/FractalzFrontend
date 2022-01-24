using FractalzWPF.Application.Domains.Requests.Todo;
using FractalzWPF.Application.Domains.Responses.Todo;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;

namespace FractalzWPF.Infrastructure.Application.Handlers.Todo
{
    public class UpdateStatusTaskHandler : TodoBaseHandler
    {
        public UpdateStatusTaskHandler(IFactoryConnector connectors) : base(connectors) { }

        public UpdateStatusTaskResponse Do(int idTask, bool completed)
        {
            var request = new UpdateStatusTaskRequest
            {
                IdTask = idTask,
                Completed = completed
            };
            var response = _connector.Send<UpdateStatusTaskResponse>(request, RequestType.UpdateStatusTask);
            return response;
        }
    }
}