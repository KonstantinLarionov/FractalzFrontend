using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractalzWPF.Application.Domains.Entities.Chat;
using FractalzWPF.Application.Domains.Entities.Todo;
using FractalzWPF.Infrastructure.Application.Domains.Entitties.Server;

namespace FractalzWPF.Application.Domains.Entities.Profile

{
    public record User
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Patro { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public UserLogo Logo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Create { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime LastLogin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TodoList TodoList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Dialog> Dialogs { get; set; }

        public ServerInfo Server { get; set; }
    }
}
