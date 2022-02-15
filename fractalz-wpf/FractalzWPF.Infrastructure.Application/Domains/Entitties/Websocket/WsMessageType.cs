using System.Runtime.Serialization;

namespace FractalzWPF.Application.Domains.Entities.Websocket
{
    public enum WsMessageType
    {
        None,
        [EnumMember(Value="User")]
        User,
        [EnumMember(Value="Dialog")]
        Dialog,
        [EnumMember(Value="Message")]
        Message
    }
}