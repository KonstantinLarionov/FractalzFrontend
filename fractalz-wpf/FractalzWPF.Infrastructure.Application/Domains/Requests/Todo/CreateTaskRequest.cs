using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzWPF.Application.Domains.Requests.Todo
{
    public class CreateTaskRequest 
    {
        public int TodoListId { get; set; }

        public string Header { get; set; }

        public string About { get; set; }

        public DateTime TimeStart { get; set; }

        public int DurationInMinute { get; set; }

        public DateTime DateCreate { get; set; } = DateTime.Now;

    }
}
