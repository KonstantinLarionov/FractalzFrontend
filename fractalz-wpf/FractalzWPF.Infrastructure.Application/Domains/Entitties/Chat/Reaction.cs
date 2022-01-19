using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Infrastructure.Application.Domains.Enums;

namespace FractalzWPF.Application.Domains.Entities.Chat
{
    public record Reaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public EmojiType EmojiType { get; set; }
        public DateTime DateTime { get; set; }
    }
}
