using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using FractalzWPF.Application.Domains.Entities.Profile;

namespace FractalzWPF.Application.Domains.Entities.Voice
{
    public class VoiceRoom
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public DateTime Updated { get; set; }

        public List<User> Users = new List<User>();
    }
}