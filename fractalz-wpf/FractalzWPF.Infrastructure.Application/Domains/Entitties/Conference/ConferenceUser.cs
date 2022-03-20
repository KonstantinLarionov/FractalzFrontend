using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FractalzWPF.Application.Domains.Entities.Conference
{
    public record ConferenceUser 
    {
        [Key]
        public int Id { get; set; }

        public int? ConferencesId { get; set; }

        public int? UsersId { get; set; }

        public bool IsTemporary { get; set; }
        public bool IsAdmin { get; set; }
    }
}