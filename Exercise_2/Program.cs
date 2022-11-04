using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        int[]oss = new int[27];
        int n, i;

        public void input()
        {
            Console.Clear();
            while (true)
            {
                Console.Write("Enter the number of elements in the array  ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 27))
                {
                    break;
                }
                else
                    Console.WriteLine("\n Array sholud have minimum 1 and maximam 27 elements. \n");
            }
            //Accept array elements
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine(" Enter array elements  ");
            Console.WriteLine("---------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                oss[i] = Int32.Parse(s1);

            }
        }

        public void Insertionsort()
        {
            int temp;
            for (int i =0; i < n; i++)
            {
                temp = oss[i];
                int OA = i - 1;
                while(OA> 0 && oss[OA]>temp)
                {

                }
            }

        }
        static void Main(string[] args)
        {
        }
    }
}
