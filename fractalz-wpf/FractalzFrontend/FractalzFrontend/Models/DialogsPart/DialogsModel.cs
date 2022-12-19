using System.Collections.Generic;
using Fractalz.Application.Domains.MappingEntities.Chat;
using Fractalz.Application.Domains.Requests.Chat;
using Fractalz.Application.Domains.Requests.User;
using Fractalz.Application.Domains.Responses;
using Fractalz.Application.Domains.Responses.Chat;
using FractalzFrontend.Application.Abstractions;
using FractalzFrontend.ViewModels.DialogsPart;
using Ninject;
using RestSharp;
using IRestClient = FractalzFrontend.Application.Abstractions.IRestClient;

namespace FractalzFrontend.Models.DialogsPart
{
    public class DialogsModel
    {
        private IRestClient _rest;
        private ICacheController _cacheController;
        private DialogsVM _vm;
        public DialogsModel(DialogsVM vm)
        {
            _vm = vm;
            _cacheController = NinjectCollection
                .Cache
                .Services
                .Get<ICacheController>();
            _rest = NinjectCollection
                .Integration
                .Services
                .Get<IRestClient>();
            SetBearer();
        }
        public bool SetBearer()
        {
            _rest.SetAuth("Authorization", "Bearer " + _cacheController.GetCache<string>("User_Token"));
            return true;
        }

        public FindUserResponse GetDialogUser()
        {
            var request = new FindUserRequest() { FindStr = _vm.UserName};
            var response = _rest.Send<FindUserResponse>(request, $"/chat/findUsers?FindStr={request.FindStr}", Method.GET,
                out var err);
            return response;
        }
    }
}