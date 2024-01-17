using System;


namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //how to take users input
            //Type your username 
            Console.WriteLine("username:");
            Console.WriteLine("age:");
            //take input from the user
            string username = Console.ReadLine();
            //input are always string, we need to change the data type
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your username is: " + username);

        }
    }
}
