using System;


namespace Hello_World
{   
    class Program
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static void swap<T>(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        public static object getType<T>(T var)
        {
            object ob = var;
            return ob.GetType();
            
        }
        public static string convertToString<T>(T var)
        {
            object obj = var;
            return obj.ToString();
        }
        public static int multiply(int a,int b)
        {
            return a * b;
        }
        static void Main()
        {
            /*Console.Write("Enter a number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe sum of two numbers is : {0} \n", Sum(n1, n2));*/
            //string str = "s32d443";
            //Console.WriteLine(str);
            /*    int a = 10, b = 69;
                Console.WriteLine("a={0}", a);
                Console.WriteLine("b={0}", b);
                swap(ref a, ref b);
                Console.WriteLine("a={0}",a);
                Console.WriteLine("b={0}",b);
                */
            int c = 69;
            float f = 6.9f;
            Console.WriteLine(getType(c));
            string a = "6*10 +9 =";
            string b = convertToString(f);
            string st = a + b;
            Console.WriteLine(st);
        }
    }
}
