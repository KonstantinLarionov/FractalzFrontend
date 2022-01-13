using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractalzWPF.Application.Domains.Entities.Todo;

namespace FractalzWPF.Application.Domains.Responses.Todo
{
    public class GetTodoListResponse : BasicResponse
    {
        public TodoList TodoList{ get; set; }
    }
}
