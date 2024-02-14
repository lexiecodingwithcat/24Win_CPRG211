using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
    {
    public class User
        {
        int id;
        string email;
        public int ID { get { return id; } set { id = value; } }
        public string Email { get { return email; } set { email = value; } }
        public User(int id, string email)
            {
            this.id = id;
            this.email = email;
            }

        }
    }
