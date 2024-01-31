using System;


namespace ConsoleApp1
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            //1.declaration of array
            
            //store finxed data type and they must be same
            //10 is size which means this array can store 10 elements
            int[] myArray = new int[10] ;
            //initialed array
            int[] myArray1 = new int[] { 1,2,3} ;
            int[] myArray3 = { 1, 2, 3, 4, 5 };
            
            // var[] myArray4 = new int[10];


            string[] strArray = new string[] { 
                "lexie cui",
                "zhenzhen wu",
                "mike gold"
                };
            //read element by loop
            foreach (string str in strArray)
                {
                Console.WriteLine(str);

                }

            int[] myArray2;
            myArray2 = new int[] { 1, 3,7,9,8, 4, 5, 6 };
            //length
            Console.WriteLine($"The length of myArray2 is {myArray2.Length}");
            //IndexOf
            var index1 = Array.IndexOf(myArray2, 8);
            Console.WriteLine($"The index of 8 is {index1}");
            //clear(array, starting point, length)
            Array.Clear(myArray2,0, 1);
            //the index0 will become 0


            foreach (var n in myArray2)
                {
                Console.WriteLine(n);
                }
            //copy()
            int[] another = new int[8]; 
            //copy myArray2 elements to another array, and the start index is 0
            myArray2.CopyTo(another, 0);
            foreach (var n in another)
                {
                Console.WriteLine(n);
                }

            //the length of the newArr should match the lenghth of the copy elements
            int[] newArr = new int[3];
            Array.Copy(myArray3, newArr, 3);
            Console.WriteLine("The new array is:");
            foreach (var n in newArr)
                {
                Console.WriteLine(n);
                }

            //sorting, from low to high
            Array.Sort(another);
            //reverse it from high to low
            Array.Reverse(another);
            Console.WriteLine("The sorting and reverse array:");
            foreach(var n in another)
                {
                Console.WriteLine(n);
                }

            Console.ReadLine();


            }
        }
    }
