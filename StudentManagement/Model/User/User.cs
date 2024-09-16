using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Core;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudentManagement.Model.User
{
    public class User:AEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public User() {
            UserName = string.Empty; // Ensures Username is never null
            Email = string.Empty;    // Ensures Email is never null
            Password = string.Empty; // Ensures Password is never null
        }

    }
}
