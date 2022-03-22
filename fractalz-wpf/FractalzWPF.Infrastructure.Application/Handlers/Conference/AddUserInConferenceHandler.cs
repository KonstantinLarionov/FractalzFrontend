
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Conference;
using FractalzWPF.Application.Domains.Responses.Conference;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Conference
{
    public class AddUserInConferenceHandler : ConferenceBaseHandler
    {
        public AddUserInConferenceHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data) { }

        public AddUserInConferenceResponse Do(int userId, int conferenceId, bool isTemp)
        {
            var request = new AddUserInConferenceRequest()
            {
                UserId = userId,
                ConferenceId = conferenceId,
                IsTemporary = isTemp
            };
            
            var response = _connector.Send<AddUserInConferenceResponse>(request, RequestType.AddUserInConference, MyInfo.Token);

            return response;
        }
    }
}