using FractalzWPF.Application.Domains.Entities.Conference;
using FractalzWPF.Application.Domains.Responses;

namespace FractalzWPF.Application.Domains.Responses.Conference
{
    public class FindConferenceResponse: BasicResponse
    {
        public ConferenceEntity ConferenceEntity { get; set; }
    }
}