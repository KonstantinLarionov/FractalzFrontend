using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractalzWPF.Application.Domains.Entities.Chat;

namespace FractalzWPF.Application.Domains.Responses.Chat
{
    public class CreateMessageResponse : BasicResponse
    {
        public Message CreatedMessage { get; set; }
    }
}
