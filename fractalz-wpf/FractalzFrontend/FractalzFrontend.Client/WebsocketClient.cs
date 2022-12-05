using Fractalz.Application.Domains.Entities.Profile;
using Fractalz.Application.Domains.Entities.Websocket;
using Fractalz.Application.Domains.MappingEntities.Chat;

using FractalzFrontend.Application.Abstractions;
using FractalzFrontend.Application.Domain;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;

using WebSocketSharp;

namespace FractalzFrontend.Client
{
    public class WebsocketClient : IWebSocketClient
    {
        private string _baseUrl;
        private WebSocket _socket;
        public delegate void MessageHandler(MessageMappedDto message);
        public event MessageHandler OnMessage;
        public delegate void DialogHandler(DialogsMappedDto message);
        public event DialogHandler OnDialogs;
        public delegate void UsersHandler(User message);
        public event UsersHandler OnUsers;
        public delegate void NotyHandler(NotySocketEvent message);
        public event NotyHandler OnNoty;
        public WebsocketClient()
        {
        }

        public void Connect(string userId)
        {
            _socket = new WebSocket(_baseUrl + "/ws/subscribe?idUser=" + userId);
            _socket.OnClose += _socket_OnClose;
            _socket.OnError += _socket_OnError;
            _socket.OnMessage += _socket_OnMessage;
            _socket.OnOpen += _socket_OnOpen;
        }

        private void _socket_OnOpen(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _socket_OnMessage(object sender, MessageEventArgs e)
        {
            var responseData = e.Data;
            var response = JsonConvert.DeserializeObject<BasicWsEntities>(responseData);
            switch (response.Type)
            {
                case WsMessageType.User:
                    this.OnUsers?.Invoke((User)response.Data);
                    break;
                case WsMessageType.Noty:
                    this.OnNoty?.Invoke((NotySocketEvent)response.Data);
                    break;
                case WsMessageType.Dialog:
                    this.OnDialogs?.Invoke((DialogsMappedDto)response.Data);
                    break;
                case WsMessageType.Message:
                    this.OnMessage?.Invoke((MessageMappedDto)response.Data);
                    break;
            }
        }

        private void _socket_OnError(object sender, ErrorEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _socket_OnClose(object sender, CloseEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
