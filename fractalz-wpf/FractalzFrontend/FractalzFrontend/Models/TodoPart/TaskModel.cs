using Fractalz.Application.Domains.Requests.Todo;
using Fractalz.Application.Domains.Responses;
using Fractalz.Application.Domains.Responses.Todo;

using FractalzFrontend.Application;
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
        private readonly TodoVM todoVM;

        public TaskModel(TaskVM taskVM)
        {
            _rest = NinjectCollection
                .Integration
                .Services
                .Get<IRestClient>();
            //this.taskVM = taskVM;
            //todoVM = this.taskVM.todoVM;
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

        public DeleteTaskResponse DeleteTask()
        {

            var request = new DeleteTaskRequest() { IdTask = Guid.Parse(taskVM.Id) };
            var result = _rest.Send<DeleteTaskResponse>(
                request,
                "/todoList/deleteTask",
                Method.DELETE,
                out var error);
            if (!result.Success && string.IsNullOrEmpty(result.Message))
            {
                result.Message = error?.Message;
                return result;
            }

            var taskIndex = todoVM.Tasks
                .IndexOf(
                    todoVM.Tasks
                        .FirstOrDefault(x => x.Id == taskVM.Id)
                 );
            todoVM.RemoveValue(taskIndex);
            todoVM.BufferTasks.Remove(todoVM.BufferTasks.FirstOrDefault(x => x.Id == taskVM.Id));

            return result;
        }

    }
}
