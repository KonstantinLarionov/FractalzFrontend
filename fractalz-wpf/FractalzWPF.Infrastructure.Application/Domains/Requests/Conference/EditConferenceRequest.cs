using System;

namespace FractalzWPF.Application.Domains.Requests.Conference
{
    public class EditConferenceRequest
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Token { get; set; }
        
        public DateTime DateTimeStart { get; set; }
        public bool DayLoop { get; set; }
    }
}