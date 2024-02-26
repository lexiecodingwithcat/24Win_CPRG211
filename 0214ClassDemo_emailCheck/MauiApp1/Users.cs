using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
    {
    public class Users
        {
        string email;
        int id;
        public string Email{ get { return email; } set { email = value; }  }
        public int Id { get { return id; } set { id = value; } }
        public Users(string email, int id)
            {
            Email = email;
            Id = id;
            }
        }
    }
