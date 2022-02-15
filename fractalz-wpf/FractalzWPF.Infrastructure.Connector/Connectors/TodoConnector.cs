using System.Collections.Generic;
using FractalzWPF.Application.Domains.Entities;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Infrastructure.Application.Domains.Entitties.Server;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using RestSharp;

namespace FractalzWPF.Infrastructure.Connector
{
    public class TodoConnector : BaseConnector
    {
        public TodoConnector()
        {
            _requests = new Dictionary<RequestType, (string, Method)>
            {
                {RequestType.GetTodoList, ("/todoList/getList", Method.GET)},
                {RequestType.CreateTask, ("/todoList/createTask", Method.POST)},
                {RequestType.UpdateStatusTask, ("/todoList/updateStatusTask", Method.PUT)},
                {RequestType.DeleteTask, ("/todoList/deleteTask", Method.DELETE)},
            };
        }

    }
}