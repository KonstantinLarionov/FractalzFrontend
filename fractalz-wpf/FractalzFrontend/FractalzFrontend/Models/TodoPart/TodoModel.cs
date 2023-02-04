using Fractalz.Application.Domains.Entities.Profile;
using Fractalz.Application.Domains.Entities.Todo;
using Fractalz.Application.Domains.Requests.Todo;
using Fractalz.Application.Domains.Responses.Todo;

using FractalzFrontend.Application.Abstractions;
using FractalzFrontend.ViewModels.TodoPart;
using FractalzFrontend.Views.TodoPart;

using Ninject;

using RestSharp;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IRestClient = FractalzFrontend.Application.Abstractions.IRestClient;
using Task = Fractalz.Application.Domains.Entities.Todo.Task;

namespace FractalzFrontend.Models.TodoPart
{
    public class TodoModel
    {
        private readonly IRestClient _rest;
        private readonly ICacheController _cacheController;
        private readonly TodoVM todoVM;

        public TodoModel(TodoVM todoVM)
        {
            _rest = NinjectCollection
                .Integration
                .Services
                .Get<IRestClient>();

            _cacheController = NinjectCollection
                .Cache
                .Services
                .Get<ICacheController>();
            this.todoVM = todoVM;
        }

        public GetTodoListResponse GetTasksByDateFrom()
        {
            todoVM.BufferTasks.Clear();
            todoVM.Tasks.Clear();
            var request = new
            {
                DateFrom = DateTime.Parse(todoVM.TodoDate).AddMinutes(-1).ToString("s"),
                UserId = _cacheController.GetCache<User>("User_Info").Id
            };
            var result = _rest.Send<GetTodoListResponse>(
                request,
                "/todoList/getList",
                RestSharp.Method.GET,
                out var error);

            if (!result?.Success == true && string.IsNullOrEmpty(result?.Message))
            {
                result.Message = error?.Message;
                return result;
            }

            result.TodoList.Tasks = result.TodoList.Tasks
                .OrderByDescending(x=>x.DateCreate)
                .ToList();

            foreach (var x in result.TodoList.Tasks)
            {
                var task = new TaskVM()
                {
                    Datetime = x.DateCreate,
                    Description = x.About,
                    Header = x.Header,
                    Id = x.Id.ToString(),
                    IsDone = x.IsCompleted,
                    todoVM = todoVM,
                };

                todoVM.BufferTasks.Add(task);
                todoVM.AddValue(task);
            }

            return result;
        }

        public void AddNewTask(TaskVM task)
        {
            if (task.Datetime.ToString("d") == todoVM.TodoDate)
                todoVM.AddValue(task);
        }

        public void SortedByIsNotDone()
        {
            var resultFilter = todoVM.BufferTasks
                .Where(x => !x.IsDone)
                .ToList();

            todoVM.AddFiltred(new ObservableCollection<TaskVM>(resultFilter));
        }
        public void SortedAll()
            => todoVM.AddFiltred(todoVM.BufferTasks);


        public UpdateStatusTaskResponse UpdateTaskStatus(string id, bool isDone)
        {
            var request = new UpdateStatusTaskRequest()
            {
                Completed = isDone,
                TodoId = Guid.Parse(id)
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

        public DeleteTaskResponse DeleteTask(string id)
        {

            var result = _rest.Send<DeleteTaskResponse>(
                null,
                "/todoList/deleteTask?IdTask="+ Guid.Parse(id),
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
                        .FirstOrDefault(x => x.Id == id)
                 );
            todoVM.RemoveValue(taskIndex);
            todoVM.BufferTasks.Remove(todoVM.BufferTasks.FirstOrDefault(x => x.Id == id));

            return result;
        }

    }
}
