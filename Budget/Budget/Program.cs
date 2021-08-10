using System;

namespace Budget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###################################################\n");
            Console.WriteLine("----------You are now using Budgeting--------------\n");
            Console.WriteLine("###################################################\n");
            Console.WriteLine("**********Press any key to continue****************\n");
            Console.ReadLine();
            Console.Write("Please enter in your total weekly expenses: ");
            int expense = Int32.Parse(Console.ReadLine());
            
            //Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
