using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzFrontend.Application.Domain
{
    public class NotySocketEvent
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public Guid From { get; set; }
    }
}
