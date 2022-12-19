using Fractalz.Application.Domains.Requests.Todo;
using Fractalz.Application.Domains.Responses.Todo;

using FractalzFrontend.Application.Abstractions;
using FractalzFrontend.ViewModels.TodoPart;

using Ninject;

using RestSharp;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using IRestClient = FractalzFrontend.Application.Abstractions.IRestClient;

namespace FractalzFrontend.Models.TodoPart
{
    public class TaskModel
    {
        private readonly IRestClient _rest;
        private readonly TaskVM taskVM;

        public TaskModel(TaskVM taskVM)
        {
            _rest = NinjectCollection
                .Integration
                .Services
                .Get<IRestClient>();
            this.taskVM = taskVM;
        }

        public UpdateStatusTaskResponse UpdateTaskStatus() 
        {
            var status = taskVM.IsDone;
            var request = new UpdateStatusTaskRequest()
            {
                Completed = status,
                TodoId = Guid.Parse(taskVM.Id)
            };
            var result = _rest.Send<UpdateStatusTaskResponse>(
                request, 
                "/todoList/updateStatusTask", 
                Method.PUT, 
                out var error);
            if (!result.Success && string.IsNullOrEmpty(result.Message))
            {
                result.Message = error?.Message;
                return result;
            }
            return result;
        }
    }
}
