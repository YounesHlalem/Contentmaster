using System;
using System.Collections.Generic;
using System.Text;

namespace ClientWPF.Mocks
{
    class MockUser
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public MockUser(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
    }
}
