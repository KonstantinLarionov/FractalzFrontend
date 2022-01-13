using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzWPF.Application.Domains.Entities.Todo
{
    public class TodoList
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public Domains.Entities.Profile.User User { get; set; }

        public ICollection<Task> Tasks { get; set; }

        public DateTime Created { get; set; }
    }
}
