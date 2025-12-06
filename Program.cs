using System;

namespace random_initialization
{
    class Program
    {
        static void initialization(int length,int[] arr)
        {
            Random x = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = x.Next();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter length of your array:");
            int lengtharr = int.Parse(Console.ReadLine());
            int[] arr = new int[lengtharr];
            initialization(lengtharr,arr);
            for (int i = 0; i < lengtharr; i++)
            {
                Console.WriteLine("the value of {0} cell: {1}",i+1,arr[i]);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("end");
            Console.ReadKey();
        }
    }
}
