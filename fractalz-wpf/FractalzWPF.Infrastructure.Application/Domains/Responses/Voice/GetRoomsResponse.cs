
using System.Collections.Generic;
using FractalzWPF.Application.Domains.Entities.Voice;

namespace FractalzWPF.Application.Domains.Responses.Voice
{
    public class GetRoomsResponse: BasicResponse
    {
        public List<VoiceRoom> Rooms { get; set; }
    }
}