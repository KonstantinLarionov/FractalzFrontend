using Fractalz.Application.Domains.Entities.Profile;
using Fractalz.Application.Domains.MappingEntities.Chat;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzFrontend.Application.Domain
{

    public class WebSocketDelegates
    {
        public delegate void MessageHandler(MessageMappedDto message);

        public delegate void DialogHandler(DialogsMappedDto message);

        public delegate void UsersHandler(User message);

        public delegate void NotyHandler(NotySocketEvent message);
    }
}
