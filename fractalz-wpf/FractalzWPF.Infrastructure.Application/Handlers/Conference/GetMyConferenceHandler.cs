using System;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Conference;
using FractalzWPF.Application.Domains.Responses.Conference;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Conference
{
    public class GetMyConferenceHandler : ConferenceBaseHandler
    {
        public GetMyConferenceHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }
        
        
        public GetMyConferenceResponse Do(int userId)
        {
            var request = new GetMyConferencesRequest()
            {
                UserId = userId
            };

            var response = _connector.Send<GetMyConferenceResponse>(request, RequestType.GetMyConferences, MyInfo.Token);

            return response;
        }
    }
}