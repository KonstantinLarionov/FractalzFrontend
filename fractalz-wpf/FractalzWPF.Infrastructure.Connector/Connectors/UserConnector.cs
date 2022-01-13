using FractalzWPF.Infrastructure.Application.Application;
using System;
using System.Collections.Generic;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Infrastructure.Application.Domains.Entitties.Server;
using FractalzWPF.Infrastructure.Connector.Objects;
using RestSharp;

namespace FractalzWPF.Infrastructure.Connector
{
    public class Connector : IConnector
    {
        private readonly Dictionary<RequestType, (string Url, Method Method)> _requestsUser;
        private User _user;
        private RestClient _client;
        
        /// <summary>
        /// Connector
        /// </summary>
        public Connector()
        {
            _requestsUser = new Dictionary<RequestType, (string, Method)>
            {
                {RequestType.Login, ("/user/login", Method.Get)},
                {RequestType.Login, ("/user/registration", Method.Post)},
                {RequestType.Login, ("/user/updateProfile", Method.Post)}
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
