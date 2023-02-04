using Fractalz.Application.Domains.Responses.User;
using FractalzFrontend.Application.Abstractions;
using FractalzFrontend.ViewModels.LoginPart;
using Ninject;
using RestSharp;
using IRestClient = FractalzFrontend.Application.Abstractions.IRestClient;

namespace FractalzFrontend.Models.LoginPart
{
    public class SignLoginModel
    {
        private SignLoginVM _loginVM;
        private readonly IRestClient _rest;
        private readonly ICacheController _cacheController;
        public SignLoginModel(SignLoginVM loginVM)
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
        public LoginResponse SignLoginRequest(object Login, object Password)
        {
            var response = _rest
                .Send<LoginResponse>(
                    new { Login = Login, Password = Password }, 
                    "/user/login", 
                    Method.GET,
                    out var error);

            if (response.Success)
            {
                _cacheController.SetCache("User_Info", response.User);
                _cacheController.SetCache("User_Token", response.Token);

                _rest.SetAuth("Authorization", "Bearer " + response.Token);
            }
            return response;
        }
    }
}