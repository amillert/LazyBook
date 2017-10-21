using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyBook.Models
{
    class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        public User(string email, string password, string userName)
        {
            Email = email;
            Password = password;
            UserName = userName;
        }
    }
}
