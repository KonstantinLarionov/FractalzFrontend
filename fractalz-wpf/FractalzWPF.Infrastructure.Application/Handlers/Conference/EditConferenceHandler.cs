using System;
using System.Threading;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Conference;
using FractalzWPF.Application.Domains.Responses.Conference;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Conference
{
    public class EditConferenceHandler: ConferenceBaseHandler
    {
        public EditConferenceHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }
        
        public EditConferenceResponse Do(int userId, DateTime start, bool datloop, int conferenceId, string name,
            string token)
        {
            var request = new EditConferenceRequest()
            {
                UserId = userId,
                DateTimeStart = start,
                DayLoop = datloop,
                Id = conferenceId,
                Name = name,
                Token = token
            };

            var response = _connector.Send<EditConferenceResponse>(request, RequestType.EditConference, MyInfo.Token);

            return response;
        }
    }
}