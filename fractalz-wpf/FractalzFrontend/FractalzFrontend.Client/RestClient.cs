﻿using FractalzFrontend.Application;

using Newtonsoft.Json;

using RestSharp;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzFrontend.Client
{
    public class RestApiClient : FractalzFrontend.Application.Abstractions.IRestClient
    {
        RestClient _client;
        public RestApiClient(string host = "http://192.168.88.152:5247") 
        { 
            _client = new RestClient(host);
        }

        public T Send<T>(object request, string resource, Method method, out ErrorResponse error)
        {
            T response = default(T);
            error = null;

            var payload = new RestRequest(resource);
            payload.Method = method;
            if (method == Method.GET)
            {
                var dict = request.ToDictionary();
                foreach (var item in dict)
                {
                    payload.AddQueryParameter(item.Key, item.Value);
                }
            }
            else
            {
                payload.AddJsonBody(request);
            }
            var result = _client.Execute(payload);
            try
            {
                response = JsonConvert.DeserializeObject<T>(result.Content);
            }
            catch(Exception ex)
            {
                error = new ErrorResponse() { Message = ex.Message, StatusCode = result.StatusCode };  
            }
            return response;
        }

        public T SendForm<T>(object request, string resource, Method method, out ErrorResponse error)
        {
            T response = default(T);
            error = null;

            var payload = new RestRequest(resource);
            payload.Method = method;
            payload.AddHeader("Content-Type", "multipart/form-data");
            var dict = request.ToDictionary();

            foreach (var item in dict)
            {
                payload.AddParameter(item.Key, item.Value);
            }
            
            var result = _client.Execute(payload); 
            try
            {
                response = JsonConvert.DeserializeObject<T>(result.Content);
            }
            catch (Exception ex)
            {
                error = new ErrorResponse() { Message = ex.Message, StatusCode = result.StatusCode };
            }

            return response;
        }
    }
}