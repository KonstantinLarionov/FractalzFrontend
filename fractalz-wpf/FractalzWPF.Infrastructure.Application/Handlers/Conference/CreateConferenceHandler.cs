using System;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Conference;
using FractalzWPF.Application.Domains.Responses.Conference;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Conference
{
    public class CreateConferenceHandler  : ConferenceBaseHandler
    {
        public CreateConferenceHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }

        public CreateConferenceResponse Do(int userId, string name, string token, DateTime start, bool dayLoop)
        {
            var request = new CreateConferenceRequest()
            {
                UserId = userId,
                Name = name,
                Token = token,
                DateTimeStart = start,
                DayLoop = dayLoop
            };

            var response = _connector.Send<CreateConferenceResponse>(request, RequestType.CreateConference, MyInfo.Token);

            return response;
        }
    }
}