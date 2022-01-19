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
            _client = new RestClient("https://localhost:5001/");
        }
        
        /// <summary>
        /// Send
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Send<T>(object message, RequestType type)
        {
            var template = _requests
                .FirstOrDefault(x => x.Key == type).Value;
            var request = new RestRequest(new Uri(template.Url), template.Method);
            if(template.Method == Method.GET)
            { request.Resource += GenerateParametersString(message); }
            else
            { request.AddJsonBody(message); }

            var result = _client.Execute(request)?.Content;
            return JsonConvert.DeserializeObject<T>(result);
        }

        private static string GenerateParametersString(object foo)
        {
            var properties = from p in foo.GetType().GetProperties()
                where p.GetValue(foo, null) != null
                select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(foo, null).ToString());

            return "?"+string.Join("&", properties.ToArray());
        }
    }
}