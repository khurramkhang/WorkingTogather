using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{


    class Tester
    {
        static void Swap<T>(ref T val1, ref T val2)
        {
            T temp = val1;
            val1 = val2;
            val2 = temp;
        }

        static T Bingo<T>()
        {
            Random rand = new Random();
            int bingo = rand.Next(0, 255);
            return (T)Convert.ChangeType(bingo, typeof(T));
        }

        public static void BubbleSort<T>(T[] arr) where T : IComparable<T>
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        flag = false;
                    }
                }
                if (flag) break;
            }
        }
        static void Main()
        {
            /*example 1*/
            int a = 13;
            int b = 644;
            Swap<int>(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            /*example 2*/
            Console.WriteLine(Bingo<char>());

            /*example 3*/
            IList<char> myList = new List<char>();
            myList.Add('I');
            myList.Add(' ');
            myList.Add('A');
            myList.Add('M');
            myList.Add(' ');
            myList.Add('G');
            myList.Add('R');
            myList.Add('O');
            myList.Add('O');
            myList.Add('T');
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i]);
            }

            /*example 4*/
            Queue<char> queue = new Queue<char>();
            queue.Enqueue('Q');
            queue.Enqueue('U');
            queue.Enqueue('E');
            queue.Enqueue('U');
            queue.Enqueue('E');
            while (queue.Count != 0)
            {
                Console.Write(queue.Dequeue());
            }

            /*example 5*/
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "red");
            dic.Add(2, "pink");
            dic.Add(5, "orange");
            dic.Add(7, "black");
            dic.Add(4, "beelu");
            string str;
            dic.TryGetValue(3, out str);
            Console.Write(str);

            /*example 6*/
            HashSet<char> vowels = new HashSet<char>() { 'A', 'E', 'I', 'O', 'U' };
            HashSet<char> consonants = new HashSet<char>() { 'D', 'C', 'B', 'Z', 'X' };
            HashSet<char> alphabets = new HashSet<char>(consonants);
            alphabets.UnionWith(vowels);
            foreach (char ch in alphabets)
            {
                Console.Write("{0} ", ch);
            }

            /*example 7*/
            Stack<int> stk = new Stack<int>();
            stk.Push(5);
            stk.Push(4);
            stk.Push(3);
            stk.Push(2);
            stk.Push(1);
            foreach (int i in stk)
            {
                Console.Write("{0} ", i);
            }
            Console.Write("\n{0} \n", stk.Peek());

            /*example 8*/
            LinkedList<double> llist = new LinkedList<double>();
            llist.AddFirst(22);
            llist.AddAfter(llist.Find(22), 45);
            llist.AddBefore(llist.Find(45), 17);
            llist.AddLast(1);
            foreach (double num in llist)
            {
                Console.WriteLine(num);
            }

            /*example 9*/
            int[] arr = { 1, 4, 35, 6, 33, 7, };
            BubbleSort<int>(arr);
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);

            /*example 10*/
            SortedList<int, char> slist = new SortedList<int, char>();
            slist.Add(1, 'P');
            slist.Add(3, 'X');
            slist.Add(2, 'I');
            slist.Add(5, 'E');
            slist.Add(4, 'I');
            foreach (KeyValuePair<int, char> ch in slist)
            {
                Console.WriteLine(ch.Value);
            }
        }
    }
}