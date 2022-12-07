using Fractalz.Application.Domains.Entities.Profile;
using Fractalz.Application.Domains.MappingEntities.Chat;

using FractalzFrontend.Application.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static FractalzFrontend.Application.Domain.WebSocketDelegates;

namespace FractalzFrontend.Application.Abstractions
{
    public interface IWebSocketClient
    {
        event MessageHandler OnMessage;

        event DialogHandler OnDialogs;

        event UsersHandler OnUsers;

        event NotyHandler OnNoty;
    }
}
