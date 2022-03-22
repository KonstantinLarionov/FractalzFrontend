using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Requests.Conference;
using FractalzWPF.Application.Domains.Responses.Conference;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application.Handlers.Conference
{
    public class DeleteUserFromConferenceHandler : ConferenceBaseHandler
    {
        public DeleteUserFromConferenceHandler(IFactoryConnector connectors, IOptions<UserData> data) : base(connectors, data)
        {
        }

        public DeleteUserFromConferenceResponse Do(int userId, int conferenceId)
        {
            var request = new DeleteUserFromConferenceRequest()
            {
                UserId = userId, ConferenceId = conferenceId
            };

            var response = _connector.Send<DeleteUserFromConferenceResponse>(request, RequestType.DeleteUserFromConference, MyInfo.Token);

            return response;
        }
    }
}