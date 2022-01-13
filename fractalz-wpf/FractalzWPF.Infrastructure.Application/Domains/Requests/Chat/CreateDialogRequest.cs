using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzWPF.Application.Domains.Requests.Chat
{
    public class CreateDialogRequest 
    {
        public List<int> UsersId { get; set; }
    }
}
