using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzWPF.Application.Domains.Requests.Todo
{
    public class GetTodoListRequest
    {
        public int UserId { get; set; }
        public DateTime? DateFrom { get; set; }
    }
}
