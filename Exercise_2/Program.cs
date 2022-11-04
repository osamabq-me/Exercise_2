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
                Console.Write("Enter the number of Students grades to the array  ");
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
            Console.WriteLine(" Enter GPA grades   ");
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
            for (int i = 0; i < n; i++)
            {
                temp = oss[i];
                int oa = i - 1;
                while (oa >= 0 && oss[oa] > temp)
                {
                    oss[oa + 1] = oss[oa];
                    oa = oa - 1;
                }
                oss[oa + 1] = temp;

            }

        }
        public void PrintArray()
        {
            for (int i = 0; i < n; i++)
                Console.Write(oss[i] + " ");
            Console.Write("\n");
        }

        static public void merge(int[] arr, int high, int mid, int low)
        {
            int i, oa, k;
            int n1 = mid - high + 1;
            int n2 = low - mid;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[high + i];
            }
            for (oa = 0; oa < n2; oa++)
            {
                R[oa] = arr[mid + 1 + oa];
            }
            i = 0;
            oa = 0;
            k = high;
            while (i < n1 && oa < n2)
            {
                if (L[i] <= R[oa])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[oa];
                    oa++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (oa < n2)
            {
                arr[k] = R[oa];
                oa++;
                k++;
            }
        }
        static public void mergeSort(int[] arr, int high, int low)
        {
            if (high < low)
            {
                int mid = (high + low) / 2;
                mergeSort(arr, high, mid);
                mergeSort(arr, mid + 1, low);
                merge(arr, high, mid, low);
            }
        }




        static void Main(string[] args)
        {
            Program se = new Program();
            int choice;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Welcome to GPA sorting assistant");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("  choose the Sorting method    ");
            Console.WriteLine("1. Insertion sort");
            Console.WriteLine("2. Merge sort     ");
            Console.WriteLine("3. Exit ");

            Console.WriteLine("Enter your choice (1,2,3)  :  ");

            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("===================");
                    Console.WriteLine("   Insertion sort   ");
                    Console.WriteLine("===================");
                    se.input();
                    se.Insertionsort();
                    se.PrintArray();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("===================");
                    Console.WriteLine("     Merge sort     ");
                    Console.WriteLine("===================");
                    int[] oss = new int[20];
                    int i, n;
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
                    Console.WriteLine(" Enter GPA grades  ");
                    Console.WriteLine("---------------------");
                    for (i = 0; i < n; i++)
                    {
                        Console.Write("<" + (i + 1) + ">");
                        string s1 = Console.ReadLine();
                        oss[i] = Int32.Parse(s1);

                    }
                    mergeSort(oss, 0, n - 1);
                    Console.WriteLine("Sorted GPA is:");
                    for (i = 0; i < n; i++)
                    {
                        Console.Write(oss[i] + " ");
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("===================");
                    Console.WriteLine("     Thank you     ");
                    Console.WriteLine("===================");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Error ");
                    break;

            }



        }
    }
}
