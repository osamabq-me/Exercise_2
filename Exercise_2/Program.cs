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



        }
        static void Main(string[] args)
        {
        }
    }
}
