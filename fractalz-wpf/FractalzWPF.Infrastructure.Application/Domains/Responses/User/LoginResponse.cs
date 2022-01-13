using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzWPF.Application.Domains.Responses.User
{
    public class LoginResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Domains.Entities.Profile.User User { get; set; }
    }
}
