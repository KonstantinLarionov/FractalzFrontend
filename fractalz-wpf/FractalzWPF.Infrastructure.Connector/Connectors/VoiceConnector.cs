using System.Collections.Generic;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using RestSharp;

namespace FractalzWPF.Infrastructure.Connector
{
    public class VoiceConnector : BaseConnector
    {
        public VoiceConnector()
        {
            _requests = new Dictionary<RequestType, (string, Method)>
            {
                {RequestType.FindOtherServer, ("/voice/findOtherServer", Method.GET)},
                {RequestType.GetOtherServers, ("/voice/getOtherServers", Method.GET)},
                {RequestType.GetMyServers, ("/voice/getMyServers", Method.GET)},
                {RequestType.CreateMyServer, ("/voice/createMyServer", Method.POST)},
                {RequestType.EditMyServer, ("/voice/editMyServer", Method.PUT)},
                {RequestType.DeleteMyServer, ("/voice/deleteMyServer", Method.DELETE)},
                {RequestType.DeleteRoom, ("/voice/deleteRoom", Method.DELETE)},
                {RequestType.GetRooms, ("/voice/getRooms", Method.GET)},
                {RequestType.GetUsersRoom, ("/voice/getUsersRoom", Method.GET)},
                {RequestType.CreateRoom, ("/voice/createRoom", Method.POST)},
                {RequestType.EditRoom, ("/voice/editRoom", Method.PUT)},
                {RequestType.InsertUserInRoom, ("/voice/insertUserInRoom", Method.POST)},
                {RequestType.DeleteUserFromRoom, ("/voice/deleteUserFromRoom", Method.DELETE)},
                {RequestType.AddOtherServer, ("/voice/addOtherServer", Method.POST)},
            };
        }
    }
}