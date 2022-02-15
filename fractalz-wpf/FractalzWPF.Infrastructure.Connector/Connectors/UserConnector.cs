using FractalzWPF.Infrastructure.Application.Application;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security;
using System.Web;
using FractalzWPF.Application.Domains.Entities;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Infrastructure.Application.Domains.Entitties.Server;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Newtonsoft.Json;
using RestSharp;

namespace FractalzWPF.Infrastructure.Connector
{
    public class UserConnector : BaseConnector
    {
        /// <summary>
        /// Connector
        /// </summary>
        public UserConnector()
        {
            _requests = new Dictionary<RequestType, (string, Method)>
            {
                {RequestType.Login, ("/user/login", Method.GET)},
                {RequestType.Reg, ("/user/registration", Method.POST)},
                {RequestType.UpdateProfile, ("/user/updateProfile", Method.POST)}
            };
        }
    }
}
