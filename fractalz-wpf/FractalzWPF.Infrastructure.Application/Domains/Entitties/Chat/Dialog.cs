using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzWPF.Application.Domains.Entities.Chat
{
    public class Dialog
    {
        public int Id { get; set; }

        [NotMapped]
        public List<Message> Messages { get; set; }

        public Message LastMessage { get; set; }

        public List<Domains.Entities.Profile.User> Users { get; set; }

        public int CountUnReadMessage { get; set; }

        public DateTime Created { get; set; }
    }
}
