using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzWPF.Application.Domains.Requests.Chat
{
    public class UpdateMessageRequest 
    {
        public int MessagId { get; set; }
        public string Text { get; set; }
    }
}
