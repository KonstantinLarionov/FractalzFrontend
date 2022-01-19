using System.Collections.Generic;
using FractalzWPF.Application.Domains.Entities;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Infrastructure.Application.Domains.Entitties.Server;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using RestSharp;

namespace FractalzWPF.Infrastructure.Connector
{
    public class ChatConnector : BaseConnector
    {
        public ChatConnector()
        {
            _requests = new Dictionary<RequestType, (string, Method)>
            {
                {RequestType.Login, ("/chat/getDialogs", Method.GET)},
                {RequestType.Login, ("/chat/getMessages", Method.GET)},
                {RequestType.Login, ("/chat/createDialog", Method.POST)},
                {RequestType.Login, ("/chat/deleteDialog", Method.DELETE)},
                {RequestType.Login, ("/chat/createMessage", Method.POST)},
                {RequestType.Login, ("/chat/updateMessage", Method.PUT)},
                {RequestType.Login, ("/chat/deleteMessage", Method.DELETE)},
                {RequestType.Login, ("/chat/reactionMessage", Method.POST)},
                {RequestType.Login, ("/chat/downloadFile", Method.GET)},
            };
        }
    }
}