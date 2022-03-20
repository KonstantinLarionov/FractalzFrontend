
namespace FractalzWPF.Application.Domains.Requests.Conference
{
    public class AddUserInConferenceRequest 
    {
        public int UserId { get; set; }
        public int ConferenceId { get; set; }
        public bool IsTemporary { get; set; }
    }
}