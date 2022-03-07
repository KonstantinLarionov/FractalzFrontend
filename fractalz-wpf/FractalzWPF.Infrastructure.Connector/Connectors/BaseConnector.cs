using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FractalzWPF.Application.Domains.Entities;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Newtonsoft.Json;
using RestSharp;

namespace FractalzWPF.Infrastructure.Connector
{
    public class BaseConnector : IConnector
    {
        protected Dictionary<RequestType, (string Url, Method Method)> _requests;
        protected RestClient _client;
        public BaseConnector()
        {
            _client = new RestClient("https://localhost:5201");
        }
        
        /// <summary>
        /// Send
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <param name="token"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Send<T>(object message, RequestType type, string token)
        {
            var template = _requests
                .FirstOrDefault(x => x.Key == type).Value;
            var request = new RestRequest(template.Url, template.Method);
            if(template.Method == Method.GET)
            { request.Resource += GenerateParametersString(message); }
            else
            {
                request.AddJsonBody(message);
            }

            if (token != null)
            {
                request.AddHeader("FX_Authorization",$"Basic {token}");
            }

            var result = _client.Execute(request);
            return JsonConvert.DeserializeObject<T>(result.Content);
        }

        private static string GenerateParametersString(object foo)
        {
            var properties = from p in foo.GetType().GetProperties()
                where p.GetValue(foo, null) != null
                select p.Name + "=" + HttpUtility.UrlEncode(p.PropertyType == typeof(DateTime?) || p.PropertyType == typeof(DateTime) ? 
                    ((DateTime)p.GetValue(foo, null)).ToString("s") :
                    p.GetValue(foo, null).ToString());

            return "?"+string.Join("&", properties.ToArray());
        }
    }
}