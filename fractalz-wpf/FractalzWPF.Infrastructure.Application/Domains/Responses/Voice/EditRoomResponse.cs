
using FractalzWPF.Application.Domains.Entities.Voice;

namespace FractalzWPF.Application.Domains.Responses.Voice
{
    public class EditRoomResponse: BasicResponse
    {
        public VoiceRoom Room { get; set; }
    }
}