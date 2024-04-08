using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Components.Pages
    {
   public class Member
        {
        private string first_name;
        private string last_name;
        private string email_address;
        private string password;
        
 
        public Member(string first_name, string last_name, string email, string password) {
            this.FirstName = first_name;
            this.LastName = last_name;
            this.EmailAddress = email;
            this.Password = password;
            }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        

        }
    }
