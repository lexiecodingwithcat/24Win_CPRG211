using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment3
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            
         SLL newlist = new SLL();
         User user = new User(2, "steven", "steven@gmail.com","hello");
         User user2 = new User(2, "LEXIE", "steven@gmail.com", "hello");
            User user3 = new User(2, "billy", "steven@gmail.com", "hello");
            User user4 = new User(3, "cc", "steven@gmail.com", "hello");
            newlist.AddFirst(user);
            newlist.AddFirst(user2);
            newlist.AddLast(user3);
            newlist.AddLast(user4);
            //newlist.Add(user3, 1);

            //Console.WriteLine(newlist.Count());

            //newlist.Replace(user2, 1);

         //  newlist.Remove(0);
         //User result = newlist.GetValue(0);
         //   bool flag = newlist.IsEmpty();
         //   Console.WriteLine(flag);
         //Console.WriteLine(result.Name);
         //newlist.Clear();
         //int a = newlist.IndexOf(user3);
         //   Console.WriteLine(a);
        
            bool flag = newlist.Contains(user4);
            Console.WriteLine(flag);

        }
    }
}
