using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MauiApp1
    {
    public class userManagement
        {
        //create a variable to hold the file
       string user_file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"D:\\SAIT\\c#\\0214ClassDemo_emailCheck\\MauiApp1\\Resources\\Res\\users.txt");
       public static List<Users> user_list = new List<Users>();
        //consrtuctor will be called automatically to read the file
        public userManagement() {
            ReadUserFile();
            }
        public void ReadUserFile()
            {
            Users user1;
            foreach (var line in File.ReadAllLines(user_file))
                {
                string[] newLine = line.Split(",");
                int id = int.Parse(newLine[0]);
                string email = newLine[1];
                user1 = new Users(email, id);
                user_list.Add(user1);

                }
            }
        public static List<Users> GetList()
            {
            return user_list;
            }



        }
   
    }
