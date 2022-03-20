using System.Collections.Generic;
using FractalzWPF.Application.Domains.Entities.Conference;
using FractalzWPF.Application.Domains.Responses;

namespace FractalzWPF.Application.Domains.Responses.Conference
{
    public class GetMyConferenceResponse : BasicResponse
    {
        public List<ConferenceEntity> Conferences { get; set; }
    }
}