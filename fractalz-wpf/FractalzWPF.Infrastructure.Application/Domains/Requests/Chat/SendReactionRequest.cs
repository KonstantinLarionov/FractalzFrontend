using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractalzWPF.Application.Domains.Entities.Chat;
using FractalzWPF.Infrastructure.Application.Domains.Enums;

namespace FractalzWPF.Application.Domains.Requests.Chat
{
    public class SendReactionRequest 
    {
        public int IdMessage { get; set; }
        public int IdUser { get; set; }
        public EmojiType EmojiType { get; set; }
    }
}
