
using FractalzWPF.Application.Domains.Entities.Voice;

namespace FractalzWPF.Application.Domains.Responses.Voice
{
    public class EditMyServerResponse: BasicResponse
    {
        public VoiceServer Server { get; set; }
    }
}