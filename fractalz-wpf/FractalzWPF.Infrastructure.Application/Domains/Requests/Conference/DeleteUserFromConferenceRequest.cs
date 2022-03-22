
namespace FractalzWPF.Application.Domains.Requests.Conference
{
    public class DeleteUserFromConferenceRequest 
    {
        public int UserId { get; set; }
        public int ConferenceId { get; set; }
    }
}