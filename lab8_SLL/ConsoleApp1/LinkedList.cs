using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
    {
    public class MyLinkedList<T>
        {
        //properties
        public int Count { get; set; }
        //the datatype should be changed here from T to string as well
        public Node<string> Head { get; set; }
        //methods
        public void AddFirst(string value) 
            {
            //give Node a specific data type when create instances
            Node<string> newNode = new Node<string>(value);
            if(Head == null) {
                Head = newNode;
                }
            else
                {
                //the new node's address will point to the current head
                newNode.Next = Head;
                //then assign new node to the head
                Head = newNode;
                }
            }

        public void AddLast(string value)
            {
            Node<string> newNode = new Node<string> (value);
            //if there is only one node in the list, then it is the first and also the last
            if (Head == null)
                {
                Head = newNode;
                }
            else
                {
                //find the one that the address is null
                //Next is null
                //search from the beginning 
                Node<string> current = Head;
                while(current.Next != null)
                    {
                    current = current.Next;
                    }
                //now the Next of current is null, which means it is the last node
                //then we add newNode to the address of current node
                current.Next = newNode;
                }

            }

        public void RemoveFirst()
            { 
            if(Head != null)
                {
                Head = Head.Next;
                } 
            }

        public void RemoveLast()
            {
            if (Head != null)
                {
                Node<string> current = Head;
                Node<string> previous = null;
                while (current.Next != null)
                    {
                    previous = current;
                    current = current.Next;
                    }
                previous.Next = null;
                }
            }

        public string GetValue(int index)
            {
            if (Head != null)
                {
                int count = 0;
                Node<string> current = Head;
                while (current.Next != null)
                    {
                    if(count == index)
                        {
                        break;
                        }
                    else
                        {
                        current = current.Next;
                        count++;
                        }
                    }
                if(index> count)
                    {
                    return "out of length";
                    }
                else
                    {
                    //need to check is the index out of total length
                    return current.Data;
                    }
               
                }
            else
                {
                return "Nothing";
                }
            }

        public int GetLength()
            {
            int length = 0;
            if( Head != null)
                {
                Node<string> current = Head;
                while (current != null)
                    {
                    length++;
                    current = current.Next;
                    }
                return length;
                }
            else
                {
                return length;
                }
            }
        
        
      




        }



    }
