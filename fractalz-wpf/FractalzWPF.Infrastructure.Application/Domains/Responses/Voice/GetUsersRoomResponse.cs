using System.Collections.Generic;

namespace FractalzWPF.Application.Domains.Responses.Voice
{
    public class GetUsersRoomResponse: BasicResponse
    {
        public List<Entities.Profile.User> Users { get; set; }
    }
}