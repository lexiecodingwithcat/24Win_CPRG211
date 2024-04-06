using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
    {
    public class SLL : ILinkedListADT
        {
        public Node<User> Head { get; set; }

        public bool IsEmpty()
            {
            if(Head == null)
                {
                return true;
                }
            else {
                return false;
                }
          
            }

        public void Clear()
            {
            Head = null;
            }


        public void AddLast(User value)
            {
            Node<User> newNode = new Node<User>(value);
            if (Head == null)
                {
                Head = newNode;
                }
            else
                {
                Node<User> current = Head;
              
                while(current.Next != null)
                    {
                    current = current.Next;
                    }
                current.Next = newNode;
                }
            }

        public void AddFirst(User value) {
            Node<User> newNode = new Node<User>(value);
            if (Head == null)
                {
                Head = newNode;
                }
            else
                {
                newNode.Next = Head;
                Head = newNode;
              
                }
            }

        public void Add(User value, int index)
            {
            //check the index and the length 
            int length = Count();
            Node<User> newNode = new Node<User>(value);
            if (index < length && index > 0)
                {
                int count = 1;
                Node<User> previous = Head;
                Node<User> current = Head.Next;
                while(current != null)
                    {
                    if(count == index)
                        {
                        previous.Next = newNode;
                        newNode.Next = current;
                        break;

                        }
                    else
                        {
                        previous = previous.Next;
                        current = current.Next;
                        count++;
                        } 
                    }
                }else if (index == 0 )
                {
               AddFirst(value);
                }
            else
                {
                throw new IndexOutOfRangeException();
                }
            }





        public void Replace(User value, int index)
            {
            int length = Count();
            int count = 0;
            if (index < length && index > 0)
                {
                Node<User> current = Head;
                while (current != null)
                    {
                    if (count == index)
                        {
                        current.Value = value;
                        break;
                        }
                    else{
                        current = current.Next;
                        count++;
                        } 
                    }
                }else if(index == 0)
                {
                Head.Value = value;
                }
            else
                {
                throw new IndexOutOfRangeException();
                }
            }



        public int Count()
         {
           int length = 0;
            if(Head != null)
                {
                length++;
                Node<User> current = Head;
                while (current.Next != null)
                    {
                    length++;
                    current = current.Next;
                    }
                }
            return length;
            }


        public void RemoveFirst()
            {
            if(Head.Next == null)
                {
                Head.Value = null;
                }
            else
                {
                //create a new node to store the second node
                Node<User> newHead = Head.Next;
                //remove the  Head
                Head.Next = null;
                //make the second one as the Head
                Head = newHead;
                }
            }

        public void RemoveLast()
            {
            if (Head.Next == null)
                {
                Head.Value = null;
                }
            else{
                Node<User> beforeCurrent = Head;
                Node<User> current = Head.Next;
                while (current.Next != null)
                    {
                    beforeCurrent = beforeCurrent.Next;
                    current = current.Next;
                    }
                beforeCurrent.Next = null;
                }
            }

        public void Remove(int index)
            {
            int length = Count();
            if(index< length && index > 0)
             {
                int count = 1;
                 Node<User> previous = Head;
                Node<User> current = Head.Next;
                while(current != null)
                    {
                    if(index == count)
                        {
                        previous.Next = current.Next;
                       
                        break;
                        }
                    else
                        {
                        previous = current;
                        current = previous.Next;
                        count++;
                        }
                    }
             }else if(index == 0)
              {
                Head = Head.Next;
                }
            else 
                {
                throw new IndexOutOfRangeException();
                }         
            }

        public User GetValue(int index)
            {
            int length = Count();
            if(index < length)
                {
                int count = 0;
                Node<User> current = Head;
                while (current != null)
                    {
                    if(index != count)
                        {
                        current = current.Next;
                        count++;
                        }
                    else
                        {
                        break;
                        }
                    }
                return current.Value;
                }
            else
                {
                throw new IndexOutOfRangeException();
                }
            }

        ////<summary>
        /// Gets the first index of element containing value.
        /// </summary>
        /// <param name="value">Value to find index of.</param>
        /// <returns>First of index of node with matching value or -1 if not found.</returns>
        public int IndexOf(User value)
            {
            Node<User> current = Head;
            int count = 0;
            while(current != null)
                {
                if (current.Value.Equals(value))
                    {
                    return count;
                    }
                else
                    {
                    current = current.Next;
                    count++;
                    }
                
                }
            
        return -1;
                
   
            }


        /// <summary>
        /// Go through nodes and check if one has value.
        /// </summary>
        /// <param name="value">Value to find index of.</param>
        /// <returns>True if element exists with value.</returns>
        public bool Contains(User value)
            {
            bool flag = false;
            Node<User> current = Head;
            while(current != null)
                {
                if(current.Value != value)
                    {
                    current = current.Next;
                    }
                else
                    {
                    flag = true;
                    break;
                    }
                }
            return flag;
            }

        ///<summary>
        ///Copy the values in linked list to array, and return an array
        public User[] TurnArray()
            {
            int length = this.Count();
            User[] arr = new User[length];
            for(int i = 0; i < length; i++)
                {
                User user = this.GetValue(i);
                arr[i] = user;
                }
            return arr;
            }




        }
    }
