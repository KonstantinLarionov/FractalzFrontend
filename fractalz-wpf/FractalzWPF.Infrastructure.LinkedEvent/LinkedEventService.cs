using System;
using FractalzWPF.Application.Domains.Entities.Chat;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Entities.Websocket;
using FractalzWPF.Infrastructure.Application.Application;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Net;

namespace FractalzWPF.Infrastructure.LinkedEvent
{
    public class LinkedEventService : ILinkedEventService
    {
        private WebSocket _ws;
        private readonly string _pathWs = $"{Constants.URL_OpenServer}:{Constants.PORT_OpenServer}:{Constants.ENDPOINT_OpenServer}";
        private readonly UserData _userInfo;

        public LinkedEventService(IOptions<UserData> userInfo)
        {
            _userInfo = userInfo.Value ?? throw new ArgumentException(nameof(userInfo));
            Connect();
        }

        #region [Socket]
        private void OnMessage(object? sender, MessageEventArgs e)
        {
            var res = GetEntity(e.Data);
            
            if (res.Type == WsMessageType.Dialog)
                DialogUpdateEvent?.Invoke((Dialog)res.Data);
            else if(res.Type == WsMessageType.Message)
                GetMessageEvent?.Invoke((Message)res.Data);
            else if(res.Type == WsMessageType.User)
                UserUpdateStatusEvent?.Invoke((User)res.Data);
        }
        #endregion

        #region [Implementation]
        public void ConnectDefaultEvent()
        {
            if (_ws.IsAlive)
            {
                _ws.Send(Constants.SUBS_Dialog);
                _ws.Send(Constants.SUBS_Message);
                _ws.Send(Constants.SUBS_User);
            }
        }
        #endregion
        
        #region [Events]
        public event ILinkedEventService.GetMessage GetMessageEvent;
        
        public event ILinkedEventService.UserUpdateStatus UserUpdateStatusEvent;
        
        public event ILinkedEventService.DialogUpdate DialogUpdateEvent;
        #endregion

        #region [Systems]
        private void Connect()
        {
            _ws = new WebSocket($"{_pathWs}?idUser={_userInfo.Id}");
            _ws.SetCookie(new Cookie(Constants.NAME_HeaderAuth, _userInfo.Token));
            _ws.OnMessage += OnMessage;
            _ws.Connect();
        }

        public BasicWsEntities GetEntity(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<BasicWsEntities>(json);
            }
            catch
            {
                return new BasicWsEntities() { Type = WsMessageType.None };
            }
        }
        #endregion
       
    }
}