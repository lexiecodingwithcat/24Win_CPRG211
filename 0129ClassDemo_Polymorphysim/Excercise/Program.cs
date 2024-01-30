using System;
using System.Collections.Generic;
using System.Xml.Schema;


namespace Excercise
    {
    interface ILoanable
        {
        void Borrow();
        }

    abstract class LibraryItems
        {
        public abstract void Return(); 
        }

    class Books : LibraryItems, ILoanable
        {
        public string Title { get; set; }
        string Author { get; set; }
        int ISBN { get; set; }
        public Books(string title,string author,int isbn)
            {
            Title = title;
            Author = author;
            ISBN = isbn;
            }
        public void Borrow()
            {
            Console.WriteLine($"The book of {Title} written by {Author}, and the ISBN is {ISBN} which has been borrowed");
            }
        public override void Return()
            {
            Console.WriteLine($"The book of {Title} written by {Author}, and the ISBN is {ISBN} which has been returned");
            }
        }




    internal class Program

        {
        static void Main(string[] args)
            {
            List<Books> booksList = new List<Books> { 
                new Books("Harry Potter", "J.K.ROLIN",123),
                new Books("Game of Thrones", "Georgia R.R. MARTIN", 456),
                new Books("High Performance JavaScript", "Nicholas C.Zakas",789)
                };

            Console.WriteLine("Please choose: 1. books, 2. movies");
            int option = int.Parse(Console.ReadLine());
            if(option == 1)
                {
                Console.WriteLine("Do you want to return or borrow? 1. borrow, 2. return, 3. exit");
                int option2 = int.Parse(Console.ReadLine());
                while (option2 != 3)
                    {
                    Console.WriteLine("Please enter the title of the book");
                    string title = Console.ReadLine();

                    if (option2 == 1)
                        {
                        foreach (Books book in booksList)
                            {
                            if (title == book.Title)
                                {
                                //booksList.Remove(book);
                                Books removeBook = book;
                                booksList.Remove(removeBook);
                                book.Borrow();
                                break;
                                }
                            Console.WriteLine("The book is borrowed");
                            }
                        }
                    else
                        {
                        foreach (Books book in booksList)
                            {
                            if (title != book.Title)
                                {
                                //booksList.Add(book);
                                Books returnBook = book;
                                booksList.Add(returnBook);
                                book.Return();
                                }
                            else
                                {
                                Console.WriteLine("The book is already returned");
                                }
                            }

                        }

                    Console.WriteLine("Do you want to return or borrow? 1. borrow, 2. return, 3. exit");
                    option2 = int.Parse(Console.ReadLine());
                    }
         

                }

            
            Console.ReadLine();

            


            }
        }
    }
