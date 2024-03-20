using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ConsoleApp1
    {

    internal class Program
        {
        static void Main(string[] args)
            {

            MyLinkedList<string> my_list = new MyLinkedList<string>();
            my_list.AddFirst("Bob");
            my_list.AddFirst("Steven");
          
            //my_list.RemoveLast();
            //my_list.RemoveFirst();


            Node<string> currentNode = my_list.Head;
            while (currentNode != null)
                {
                Console.WriteLine(currentNode.Data);
                //move to the next node
                currentNode = currentNode.Next;
                }

            Console.WriteLine("--------");
            Console.WriteLine(my_list.GetValue(0));
            string result = Convert.ToString(my_list.GetLength());
            Console.WriteLine(result);
         

            Console.ReadLine();




            }
        }
    }
