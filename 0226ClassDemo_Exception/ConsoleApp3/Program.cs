using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string text = null;
          
            try {

                if (text != null)
                    {
                    int length = text.Length;
                    Console.Write($"Length of a string is {length}");
                    }else
                    {
                    //throw can explicitly raise exceptions
                    //The throw statement allows you to create a custom error.
                    // and can customize error messge directly
                    //the prohgram will stop execution after throw the exceptions
                    throw new Exception("empty string");
                    }
                }
            //catch and handle exceptions
            catch (NullReferenceException ex) //lower priority
                {
                Console.WriteLine("A null reference exception occur");
                Console.WriteLine(ex.Message);
                }
            catch(Exception ex) //high priority
                {
                Console.WriteLine(ex.Message);
                }
            finally
                {
                Console.WriteLine("Final block");
                }
            
            //NullReferenceException
            //object reference not set to an instance of an object

            Console.ReadLine();

            }
        }
    }
