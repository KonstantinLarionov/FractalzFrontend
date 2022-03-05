
namespace FractalzWPF.Application.Domains.Requests.Voice
{
    public class EditRoomRequest 
    {
        public int RoomId { get; set; }
        public string NameRoom { get; set; }
        public int CountMax { get; set; }
    }
}