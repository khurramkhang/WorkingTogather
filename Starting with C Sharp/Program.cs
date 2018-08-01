using System;


namespace Hello_World
{   
    class Program
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe sum of two numbers is : {0} \n", Subtraction(n1, n2));
            
        }
    }
}
