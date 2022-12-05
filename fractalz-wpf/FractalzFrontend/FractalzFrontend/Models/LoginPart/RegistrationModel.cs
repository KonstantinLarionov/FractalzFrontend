using Fractalz.Application.Domains.Requests.User;
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

using IRestClient = FractalzFrontend.Application.Abstractions.IRestClient;

namespace FractalzFrontend.Models.LoginPart
{
    public class RegistrationModel
    {
        private RegistrationVM _regVM;
        private readonly IRestClient _rest;
        private readonly ICacheController _cacheController;
        public RegistrationModel(RegistrationVM regVM)
        {
            _regVM = regVM;

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
        /// RegistrationRequest
        /// </summary>
        /// <returns></returns>
        public RegistrationResponse RegistrationRequest()
        {
            var request = new RegistrationRequest
            {
                Login = _regVM.Login,
                Password = _regVM.Password,
                Email = _regVM.Email,
            };
            var response = _rest
                .Send<RegistrationResponse>(
                request,
                "/user/registration",
                 Method.POST,
                out var error);

            return response;
        }

        /// <summary>
        /// SendCodeRequest
        /// </summary>
        /// <returns></returns>
        public CodeGenerateResponse SendCodeRequest()
        {
            if (string.IsNullOrEmpty(_regVM.Email))
            {
                return new CodeGenerateResponse()
                {
                    Message = "Введите почту для отправки",
                    Success = false
                };
            }
            var request = new CodeGenerateRequest()
            { 
                Email = _regVM.Email,
            };
            var response = _rest
                .Send<CodeGenerateResponse>(
                request,
                "/user/sendCode",
                 Method.PUT,
                out var error);

            return response;
        }

        /// <summary>
        /// ValidCodeRequest
        /// </summary>
        /// <returns></returns>
        public CodeValidResponse ValidCodeRequest()
        {
            if (string.IsNullOrEmpty(_regVM.Email))
            {
                return new CodeValidResponse()
                {
                    Message = "Введите почту для проверки",
                    Success = false
                };
            }
            if (string.IsNullOrEmpty(_regVM.Code))
            {
                return new CodeValidResponse()
                {
                    Message = "Введите код для отправки",
                    Success = false
                };
            }


            var request = new CodeValidRequest()
            {
                AuthCode = _regVM.Code,
                Email = _regVM.Email
            };

            var response = _rest
                .Send<CodeValidResponse>(
                request,
                "/user/validCode",
                 Method.PUT,
                out var error);

            return response;
        }
    }
}
