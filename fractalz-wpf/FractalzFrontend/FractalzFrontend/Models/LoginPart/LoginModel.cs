using Fractalz.Application.Domains.Responses.User;

using FractalzFrontend.Application.Abstractions;
using FractalzFrontend.ViewModels.LoginPart;

using Ninject;

using RestSharp;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using IRestClient = FractalzFrontend.Application.Abstractions.IRestClient;

namespace FractalzFrontend.Models.LoginPart
{
    public class LoginModel
    {
        private LoginVM _loginVM;
        private readonly IRestClient _rest;
        private readonly ICacheController _cacheController;
        public LoginModel(LoginVM loginVM)
        {
            _loginVM = loginVM;

            _cacheController = NinjectCollection
                .Cache
                .Services
                .Get<ICacheController>();
            _rest = NinjectCollection
                .Integration
                .Services
                .Get<IRestClient>();
        }

        /// <summary>
        /// LoginRequest
        /// </summary>
        /// <returns></returns>
        public LoginResponse LoginRequest()
        {
            var response = _rest
                .Send<LoginResponse>(
                new { Login = _loginVM.Login, Password = _loginVM.Password }, 
                "/user/login", 
                Method.GET,
                out var error);
            if (response == null && error == null)
            {
                return new LoginResponse() { Success = false, Message = "Сервер не отвечает" };
            }
            if (response.Success)
            {
                _cacheController.SetCache("User_Info", response.User);
                _cacheController.SetCache("User_Token", response.Token);
            }
            return response;
        }
    }
}
