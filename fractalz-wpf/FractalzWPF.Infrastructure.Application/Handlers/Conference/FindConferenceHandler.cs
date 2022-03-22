using System;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Conference;
using FractalzWPF.Application.Domains.Responses.Conference;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Conference
{
    public class FindConferenceHandler : ConferenceBaseHandler
    {
        public FindConferenceHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }
        
        public FindConferenceResponse Do(int userId, DateTime start, bool datloop, int conferenceId, string name,
            string token)
        {
            var request = new FindConferenceByTokenRequest()
            {
                Token = token
            };

            var response = _connector.Send<FindConferenceResponse>(request, RequestType.FindConferenceByToken, MyInfo.Token);

            return response;
        }
    }
}