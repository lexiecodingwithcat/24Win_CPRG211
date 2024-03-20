using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
    {
    public class Node<T>
    {
     //data
       public T Data;
    // link
       public Node<T> Next;
    //    //constructor
       public Node(T data)
           {
            this.Data = data;
            this.Next = null;
         }

      }
    }
