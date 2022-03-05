
using FractalzWPF.Application.Domains.Entities.Voice;

namespace FractalzWPF.Application.Domains.Responses.Voice
{
    public class FindServerResponse: BasicResponse
    {
        public VoiceServer Servers { get; set; }
    }
}