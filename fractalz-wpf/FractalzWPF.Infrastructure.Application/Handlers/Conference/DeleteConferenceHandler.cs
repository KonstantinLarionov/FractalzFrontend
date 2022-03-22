using System;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Conference;
using FractalzWPF.Application.Domains.Responses.Conference;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Conference
{
    public class DeleteConferenceHandler : ConferenceBaseHandler
    {
        public DeleteConferenceHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }
        
        public DeleteConferenceResponse Do(int userId, int conferenceId)
        {
            var request = new DeleteConferenceRequest()
            {
                UserId = userId, Id = conferenceId
            };

            var response = _connector.Send<DeleteConferenceResponse>(request, RequestType.DeleteConference, MyInfo.Token);

            return response;
        }
    }
}