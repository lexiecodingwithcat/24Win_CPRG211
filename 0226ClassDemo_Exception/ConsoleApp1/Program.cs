using System;
//system already has a exception, calling system do not need calling exception
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            //out of range error
            //int[] number = { 1, 2, 3, 4 };
            //try 
            //    { 
            //    Console.WriteLine(number[5]); 
            //    }
            //catch (Exception ex) { 
            //    Console.WriteLine("index out of bound");
            //    }


            //try {
            //    int a = 10;
            //    int b = 0;
            //    int c = a / b;
            //    Console.WriteLine(c);
            //    }
            //catch ( Exception ex)
            //    {
            //    Console.WriteLine(ex.Message, ex.StackTrace);
            //    }
            try
                {
                string my_file = "data.txt";
                using (StreamReader sr = new StreamReader(my_file))
                    {
                    Console.WriteLine(sr.ReadToEnd());
                    }
                }
            catch (FileNotFoundException ex){
                Console.WriteLine(ex.Message);
                }
            //if it is other errors. we can handle multiple catches
            catch(Exception ex) 
                {
                Console.WriteLine(ex.Message);
                }
            //multiple catches are allowed but only one finally
            //finally can be used without catch
            finally
                {
                Console.WriteLine("This will always execute");
                }




            Console.ReadLine();
            



            }
        }
    }
