using System.Collections.Generic;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Infrastructure.Application.Domains.Entitties.Server;
using FractalzWPF.Infrastructure.Connector.Objects;
using RestSharp;

namespace FractalzWPF.Infrastructure.Connector
{
    public class TodoConnector
    {
        
        private readonly Dictionary<RequestType, (string Url, Method Method)> _requestsTodo;
        private User _user;
        private RestClient _client;
        public TodoConnector()
        {   
            _requestsTodo = new Dictionary<RequestType, (string, Method)>
            {
                {RequestType.Login, ("/todoList/getList", Method.Get)},
                {RequestType.Login, ("/todoList/createTask", Method.Post)},
                {RequestType.Login, ("/todoList/updateStatusTask", Method.Put)},
                {RequestType.Login, ("/todoList/deleteTask", Method.Delete)},
            };
        }
        /// <summary>
        /// BuildConnector
        /// </summary>
        /// <param name="user">user</param>
        /// <param name="info">info</param>
        /// <returns></returns>
        public bool BuildConnector(User user, ServerInfo info)
        {
            if (string.IsNullOrEmpty(user.Login))
                return false;
            if (string.IsNullOrEmpty(user.Password))
                return false;
            if (string.IsNullOrEmpty(user.Email))
                return false;
            if (string.IsNullOrEmpty(info.Host))
                return false;
            _user = user;
            _client = new RestClient(info.Host);
            return true;
        }
    }
}