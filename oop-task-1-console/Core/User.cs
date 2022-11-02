using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_task_1_console.Core
{
    internal class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        private readonly string _registrationDate;
        public string RegistrationDate { get => _registrationDate; } 

        public User(string registrationDate)
        {
            _registrationDate = registrationDate;
        }
    }
}
