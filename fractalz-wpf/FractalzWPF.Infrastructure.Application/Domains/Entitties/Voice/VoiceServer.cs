using System;
using System.Collections.Generic;

namespace FractalzWPF.Application.Domains.Entities.Voice
{
    public class VoiceServer
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public DateTime Updated { get; set; }
        
        public List<VoiceRoom> Rooms { get; set; } = new List<VoiceRoom>();
    }
}