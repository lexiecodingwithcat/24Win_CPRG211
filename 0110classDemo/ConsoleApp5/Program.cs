using System;


namespace ConsoleApp5
{
    internal class Program
    {
        class Calculater
        {
            public double number1;
            public double number2;

            public void Get_add()
            {
                double result1 = number1 + number2;
                Console.WriteLine("number1 + number2 = " + result1);

            }
            public void Get_substract()
            {
                double result2 = number1 - number2;
                Console.WriteLine("number1 - number2 = " + result2);

            }
            public void Get_multiple()
            {
                double result3 = number1 * number2;
                Console.WriteLine("number1 * number2 = " + result3);

            }
            public void Get_devide()
            {
                double result4 = number1 / number2;
                Console.WriteLine("number1 / number2 = " + result4);

            }

        }
        static void Main(string[] args)
        {

            //[09:33] Kamini Sehmi
            //create a calculator that can perform addition, subtraction, multiplication, divsion.
            //[09:34] Kamini Sehmi
            //create class and function objects and use switch case for that

            //take the input from users and change the data type to double
            Calculater calculater1 = new Calculater();
            Boolean flag = false;
            while(flag == false) {
             Console.WriteLine("Please select: 1.addiction 2.substraction 3. multiplication 4. division 5. exit");
             int option = Convert.ToInt32(Console.ReadLine());
            if(option == 5)
                {
                 flag = true;
                 Console.WriteLine("Thank you for using this calculator! Good bye:)");
                 break;
                }
            else
                {
                 while (option > 5 || option < 1)
                    {
                        Console.WriteLine("invalid option, please choose number from 1 to 5: ");
                        option = Convert.ToInt32(Console.ReadLine());
                    }
                }
               
            Console.WriteLine("Enter the first number:");
            double number1 = Convert.ToDouble( Console.ReadLine());
            calculater1.number1 = number1;
            Console.WriteLine("Enter the second number:");
            double number2 = Convert.ToDouble(Console.ReadLine());
            calculater1.number2 = number2;
            //Console.WriteLine("Please select: 1.addiction 2.substraction 3. multiplication 4. division 5. exit");
            //int option = Convert.ToInt32( Console.ReadLine());
       

            switch (option)
            {
                case 1:
                    calculater1.Get_add(); 
                    break;
                case 2:
                    calculater1.Get_substract();
                    break; 
                case 3:
                    calculater1.Get_multiple();
                    break;
                case 4:
                    calculater1.Get_devide();
                    break;  
               
            }
            }
            Console.ReadLine();
        }
    }
}
