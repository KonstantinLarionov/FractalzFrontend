using FractalzWPF.Application.Domains.Entities.Voice;

namespace FractalzWPF.Application.Domains.Responses.Voice
{
    public class CreateMyServerResponse : BasicResponse
    {
        public VoiceServer Server { get; set; }
    }
}