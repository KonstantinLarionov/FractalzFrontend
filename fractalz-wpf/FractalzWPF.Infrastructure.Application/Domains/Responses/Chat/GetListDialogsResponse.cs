
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractalzWPF.Application.Domains.Entities.Chat;
using FractalzWPF.Application.Domains.Responses;

namespace FractalzWPF.Application.Domains.Responses.Chat
{
    public class GetListDialogsResponse : BasicResponse
    {
        public List<Dialog> Dialogs { get; set; }
    }
}
