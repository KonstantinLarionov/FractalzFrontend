using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzWPF.Application.Domains.Requests.Chat
{
    public class CreateMessageRequest
    {
        public int UserId { get; set; }
        public int DialogId { get; set; }
        public string Message { get; set; }
    }
}
