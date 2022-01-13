using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzWPF.Application.Domains.Requests.Todo
{
    public class UpdateStatusTaskRequest 
    {
        [Required]
        public int IdTask { get; set; }

        [Required]
        public bool Completed { get; set; }
    }
}
