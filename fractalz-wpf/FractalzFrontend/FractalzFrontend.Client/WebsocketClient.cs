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

using static FractalzFrontend.Application.Domain.WebSocketDelegates;

namespace FractalzFrontend.Client
{
    public class WebsocketClient : IWebSocketClient
    {
        private string _baseUrl = "ws://192.168.88.152:5247";
        private WebSocket _socket;
        private ILogDispatcher _log;

        public event MessageHandler OnMessage;
        public event DialogHandler OnDialogs;
        public event UsersHandler OnUsers;
        public event NotyHandler OnNoty;
        public WebsocketClient()
        {
        }

        public void SetLogger(ILogDispatcher logDispatcher) => this._log = logDispatcher;

        public void Connect(string userId)
        {
            _log.SetFileName(LoggerNameFile.SocketState);

            _socket = new WebSocket(_baseUrl + "/ws/subscribe?idUser=" + userId);
            _socket.OnClose += _socket_OnClose;
            _socket.OnError += _socket_OnError;
            _socket.OnMessage += _socket_OnMessage;
            _socket.OnOpen += _socket_OnOpen;
            _socket.Connect();

            _log.Success("WebSocket", "SocketTryConnect");
        }

        private void _socket_OnOpen(object sender, EventArgs e) =>
            _log.Success("SocketOpen", e.ToString());

        private void _socket_OnMessage(object sender, MessageEventArgs e)
        {
            var responseData = e.Data;
            _log.Info("OnMessage", e.Data);

            var response = JsonConvert.DeserializeObject<BasicWsEntities>(responseData);

            switch (response.Type)
            {
                case WsMessageType.User:
                    _log.Info("OnUser", e.Data);

                    this.OnUsers?.Invoke((User)response.Data);
                    break;
                case WsMessageType.Noty:
                    _log.Info("OnNoty", e.Data);

                    this.OnNoty?.Invoke((NotySocketEvent)response.Data);
                    break;
                case WsMessageType.Dialog:
                    _log.Info("OnDialog", e.Data);

                    this.OnDialogs?.Invoke((DialogsMappedDto)response.Data);
                    break;
                case WsMessageType.Message:
                    _log.Info("OnMessage", e.Data);

                    this.OnMessage?.Invoke((MessageMappedDto)response.Data);
                    break;
            }
        }

        private void _socket_OnError(object sender, ErrorEventArgs e) =>
            _log.Error("SocketError", e.Message + Environment.NewLine + e.Message);

        private void _socket_OnClose(object sender, CloseEventArgs e) =>
            _log.Info("SocketClose", e.Code + e.Reason);
    }
}
