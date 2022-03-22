using System.Collections.Generic;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using RestSharp;

namespace FractalzWPF.Infrastructure.Connector
{
    public class ConferenceConnector : BaseConnector
    {
        public ConferenceConnector()
        {
            _requests = new Dictionary<RequestType, (string, Method)>
            {
                {RequestType.GetMyConferences, ("/conference/getMyConferences", Method.GET)},
                {RequestType.FindConferenceByToken, ("/conference/findConferenceByToken", Method.GET)},
                {RequestType.EditConference, ("/conference/editConference", Method.PUT)},
                {RequestType.DeleteConference, ("/conference/deleteConference", Method.DELETE)},
                {RequestType.CreateConference, ("/conference/createConference", Method.POST)},
                {RequestType.AddUserInConference, ("/conference/addUserInConference", Method.POST)},
                {RequestType.DeleteUserFromConference, ("/conference/deleteUserFromConference", Method.DELETE)},
            };
        }
    }
}