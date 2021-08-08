using System;

namespace Budget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("####### You are now using Budgeting ######");
            Console.WriteLine("******* Press any key to continue *******");
            Console.ReadLine();
            Console.WriteLine("Please enter in your total weekly expenses ");
            int expense = Int32.Parse(Console.ReadLine());
            
            //Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
