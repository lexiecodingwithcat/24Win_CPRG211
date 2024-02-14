using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
    {
    public class UserManager
        {
        string User_text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "D:\\SAIT\\c#\\0214ClassDemo_emailCheck\\MauiApp1\\Resources\\Res\\users.txt");
        public static List<User> Users = new List<User>();
        public UserManager()
            {
            populateUsers();
            }
        //read data from the file
        public void populateUsers()
            {
            User user;
            //Read each line from the list
            foreach (var item in File.ReadAllLines(User_text))
                {
                string[] parts = item.Split(",");
                int id = int.Parse(parts[0]);
                string email = parts[1];
                user = new User(id, email);
                Users.Add(user); //add user into database
                }
            }
        //Return a list
        public static List <User> GetUsers()
            {
            return Users;
            }
        
        }
    }
