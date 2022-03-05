
using System.Collections.Generic;
using FractalzWPF.Application.Domains.Entities.Voice;

namespace FractalzWPF.Application.Domains.Responses.Voice
{
    public class GetOtherServersResponse: BasicResponse
    {
        public List<VoiceServer> Servers { get; set; }
    }
}