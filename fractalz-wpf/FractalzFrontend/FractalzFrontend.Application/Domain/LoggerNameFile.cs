using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FractalzFrontend.Application.Domain
{
    public enum LoggerNameFile
    {
        [EnumMember(Value = "AllState.html")]
        AllState,
        [EnumMember(Value = "SocketState.html")]
        SocketState,
        [EnumMember(Value = "RestState.html")]
        RestState,
    }
}
