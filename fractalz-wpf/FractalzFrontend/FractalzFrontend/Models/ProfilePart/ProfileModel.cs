using System;
using System.Collections.Generic;
using System.Linq;
using Fractalz.Application.Domains.Entities.Profile;
using Fractalz.Application.Domains.Requests.User;
using Fractalz.Application.Domains.Responses;
using Fractalz.Application.Domains.Responses.User;
using FractalzFrontend.Application.Abstractions;
using FractalzFrontend.Client;
using FractalzFrontend.ViewModels.ProfilePart;
using Ninject;
using RestSharp;
using IRestClient = FractalzFrontend.Application.Abstractions.IRestClient;

namespace FractalzFrontend.Models.ProfilePart
{
    public class ProfileModel
    {
        private ProfileVM _profileVm;
        private readonly IRestClient _rest;
        private readonly ICacheController _cacheController;
        private Guid UserId;
        public ProfileModel(ProfileVM profileVm)
        {
            _profileVm = profileVm;
            
            _cacheController = NinjectCollection
                .Cache
                .Services
                .Get<ICacheController>();
            _rest = NinjectCollection
                .Integration
                .Services
                .Get<IRestClient>();
            GetUserId();
        }

        public bool SetBearer()
        {
            _rest.SetAuth("Authorization", "Bearer " + _cacheController.GetCache<string>("User_Token"));
            return true;
        }

        public Guid GetUserId()
        {
            UserId = _cacheController.GetCache<User>("User_Info").Id;
            return UserId;
        }

        public UpdateProfileResponse UpdateUserInfo()
        {
            SetBearer();
            var request = new UpdateProfileRequest
            {
                Address = _profileVm.Adress,
                Email = _profileVm.Email,
                Login = _profileVm.Login,
                Logo = _profileVm.Logo,
                Name = _profileVm.Name,
                Number = _profileVm.Number,
                UserId = _cacheController.GetCache<User>("User_Info").Id,
                TGLink = _profileVm.TgLink,
                VKLink = _profileVm.VkLink,
                Background = _profileVm.Background,
                
                
            };
            var response = _rest.Send<UpdateProfileResponse>
            (
                request,
                "/user/updateProfile", Method.POST, out var err);
            return response;
        }

        public GetUserResponse GetUser()
        {
            var response = _rest.Send<GetUserResponse>(UserId, $"/user/getUser/?UserId={UserId}", Method.GET, out var err);
            return response;
        }
    }

    public class UserToken
    {
        public string Token;
    }
}