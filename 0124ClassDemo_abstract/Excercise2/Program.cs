using System;


namespace Excercise2
    {
    interface ILearnerand
        {
        void Study();
        }
    interface IWorkerand {
        void Work();
        }
    class StudentWorker: ILearnerand, IWorkerand
        {
        public void Study()
            {
            Console.WriteLine("I am studying");
            }
        public void Work()
            {
            Console.WriteLine("I am working");
            }
        }




    public class Program
        {
        static void Main(string[] args)
            {
        StudentWorker studentworker1 = new StudentWorker();
            studentworker1.Study();
            studentworker1.Work();


            Console.ReadLine();
            }
        }
    }
