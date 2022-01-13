using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzWPF.Application.Domains.Entities.Todo
{
    public class Task
    {
        public int Id { get; set; }

        public int TodoListId { get; set; }

        [ForeignKey(nameof(TodoListId))]
        public TodoList TodoList { get; set; }

        public string Header { get; set; }

        public string About { get; set; }

        public DateTime TimeStart { get; set; }

        public DateTime DateCreate { get; set; }

        public int DurationInMinute { get; set; }

        public bool IsCompleted { get; set; }
    }
}
