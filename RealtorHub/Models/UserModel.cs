using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealtorHub.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        private string password;

        private string GetPassword()
        {
            return password;
        }

        private void SetPassword(string value)
        {
            password = value;
        }
    }
}
