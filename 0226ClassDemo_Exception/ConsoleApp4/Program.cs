using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            try
                {
                //checked is used to check the calculation
                //if there is no checked, there will be no overflow check and it will
                //automatically cut the overflow part
                checked {
                    //int a = int.MaxValue +1; 
                    //if we write in this way, it won't be compiled since the system can notice the overflow error
                    int a = int.MaxValue;
                        int b = 1;
                    int c = a + b;
                    }
                }
            catch (OverflowException) {
                Console.WriteLine("overflow caught");
                }




            }
        }
    }
