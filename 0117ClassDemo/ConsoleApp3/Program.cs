using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
    {
    class Program
        {
        static class FizzBuzz
            {
            static public int number = 1;
            static public void Fizzbuzz()
                {
                for (int i = number; i <= 100; i++)
                    {
                    if (i % 3 == 0)
                        {
                        if (i % 5 == 0)
                            {
                            Console.WriteLine($"{i}FizzBuzz");
                            }
                        else
                            {
                            Console.WriteLine($"{i}Fizz");
                            }

                        }
                    else if (i % 5 == 0)
                        {
                        Console.WriteLine($"{i}Buzz");
                        }
                    else
                        {
                        Console.WriteLine(i);
                        }
                    }
                }
            }
        static void Main(string[] args)
            {
            FizzBuzz.Fizzbuzz();
           

            Console.ReadLine();
            }
        }
    }
