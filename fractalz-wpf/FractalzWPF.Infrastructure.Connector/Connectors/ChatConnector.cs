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
                {RequestType.GetListDialog, ("/chat/getDialogs", Method.GET)},
                {RequestType.GetMessageHistory, ("/chat/getMessages", Method.GET)},
                {RequestType.CreateDialog, ("/chat/createDialog", Method.POST)},
                {RequestType.DeleteDialog, ("/chat/deleteDialog", Method.DELETE)},
                {RequestType.CreateMessage, ("/chat/createMessage", Method.POST)},
                {RequestType.UpdateMessage, ("/chat/updateMessage", Method.PUT)},
                {RequestType.DeleteMessage, ("/chat/deleteMessage", Method.DELETE)},
                {RequestType.SendReactionMessage, ("/chat/reactionMessage", Method.POST)},
                {RequestType.DownloadFile, ("/chat/downloadFile", Method.GET)},
            };
        }
    }
}