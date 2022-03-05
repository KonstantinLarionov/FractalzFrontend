
using FractalzWPF.Application.Domains.Entities.Voice;

namespace FractalzWPF.Application.Domains.Responses.Voice
{
    public class CreateRoomResponse: BasicResponse
    {
        public VoiceRoom Room { get; set; }
    }
}