using System.Collections.Generic;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Infrastructure.Application.Domains.Entitties.Server;
using FractalzWPF.Infrastructure.Connector.Objects;
using RestSharp;

namespace FractalzWPF.Infrastructure.Connector
{
    public class ChatConnector
    {
        
        private readonly Dictionary<RequestType, (string Url, Method Method)> _requestsChat;
        private User _user;
        private RestClient _client;
        public ChatConnector()
        {
            _requestsChat = new Dictionary<RequestType, (string, Method)>
            {
                {RequestType.Login, ("/chat/getDialogs", Method.Get)},
                {RequestType.Login, ("/chat/getMessages", Method.Get)},
                {RequestType.Login, ("/chat/createDialog", Method.Post)},
                {RequestType.Login, ("/chat/deleteDialog", Method.Delete)},
                {RequestType.Login, ("/chat/createMessage", Method.Post)},
                {RequestType.Login, ("/chat/updateMessage", Method.Put)},
                {RequestType.Login, ("/chat/deleteMessage", Method.Delete)},
                {RequestType.Login, ("/chat/reactionMessage", Method.Post)},
                {RequestType.Login, ("/chat/downloadFile", Method.Get)},
            };
        }
        /// <summary>
        /// BuildConnector
        /// </summary>
        /// <param name="user">user</param>
        /// <param name="info">info</param>
        /// <returns></returns>
        public bool BuildConnector(User user, ServerInfo info)
        {
            if (string.IsNullOrEmpty(user.Login))
                return false;
            if (string.IsNullOrEmpty(user.Password))
                return false;
            if (string.IsNullOrEmpty(user.Email))
                return false;
            if (string.IsNullOrEmpty(info.Host))
                return false;
            _user = user;
            _client = new RestClient(info.Host);
            return true;
        }
    }
}