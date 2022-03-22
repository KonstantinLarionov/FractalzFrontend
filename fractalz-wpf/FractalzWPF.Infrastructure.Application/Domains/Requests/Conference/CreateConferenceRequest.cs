using System;
namespace FractalzWPF.Application.Domains.Requests.Conference
{
    public class CreateConferenceRequest 
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        
        public string Token { get; set; }
        
        public DateTime DateTimeStart { get; set; }
        public bool DayLoop { get; set; }
    }
}