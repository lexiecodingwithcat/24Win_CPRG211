using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
    {
    public class Node<T>
        {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value)
            {
            this.Value = value;
            this.Next = null;
            }
        }
   
    }
