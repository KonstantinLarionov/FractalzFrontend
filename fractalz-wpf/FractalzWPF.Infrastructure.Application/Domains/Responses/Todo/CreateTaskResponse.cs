using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzWPF.Application.Domains.Responses.Todo
{
    public class CreateTaskResponse : BasicResponse
    {
        public int IdTask { get; set; }
    }
}
