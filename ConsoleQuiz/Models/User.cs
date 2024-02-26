using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuiz.Models
{
    internal class User : Entity
    {
        public string Username { get; set; }
        public string userPassword { get; set; }

        public string Email { get; set; }

    }
}
