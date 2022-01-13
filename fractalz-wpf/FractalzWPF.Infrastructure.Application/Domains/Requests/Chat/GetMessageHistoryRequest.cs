
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzWPF.Application.Domains.Requests.Chat
{
    public class GetMessageHistoryRequest 
    {
        public int IdDialog { get; set; }
        public DateTime DateFrom { get; set; }
        public int CountMessage { get; set; }
    }
}
