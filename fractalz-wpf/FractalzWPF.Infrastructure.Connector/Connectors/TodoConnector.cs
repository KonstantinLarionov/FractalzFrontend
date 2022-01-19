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
                {RequestType.Login, ("/todoList/getList", Method.GET)},
                {RequestType.Login, ("/todoList/createTask", Method.POST)},
                {RequestType.Login, ("/todoList/updateStatusTask", Method.PUT)},
                {RequestType.Login, ("/todoList/deleteTask", Method.DELETE)},
            };
        }

    }
}