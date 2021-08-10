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

            Console.Write("\n");

            Console.Write("Please enter in your age in the range of 25 - 30 years old: ");
            string age = Console.ReadLine();

            Console.Write("\n");

            Console.WriteLine("//////Calculation process complete. Press any key to see your result//////");

            Console.Write("\n");

            Console.ReadLine();

            if (expense <= 250 && age == "24")
            {
                Console.WriteLine("For a 24 year old, you are within your budget. Good job!");
            }
            else if (expense > 250 && age == "24")
            {
                Console.WriteLine("For a 24 year old, you are spending too much. Please reflect on what you have been spending your money on recently.");
            }

            if (expense <= 300 && age == "25")
            {
                Console.WriteLine("For a 25 year old, you are within your budget. Good job!");
            }
            else if (expense > 300 && age == "25")
            {
                Console.WriteLine("For a 25 year old, you are spending too much. Please reflect on what you have been spending your money on recently.");
            }

            if (expense <= 350 && age == "26")
            {
                Console.WriteLine("For a 26 year old, you are within your budget. Good job!");
            }
            else if (expense > 350 && age == "26")
            {
                Console.WriteLine("For a 26 year old, you are spending too much. Please reflect on what you have been spending your money on recently.");
            }

            if (expense <= 400 && age == "27")
            {
                Console.WriteLine("For a 27 year old, you are within your budget. Good job!");
            }
            else if (expense > 400 && age == "27")
            {
                Console.WriteLine("For a 27 year old, you are spending too much. Please reflect on what you have been spending your money on recently.");
            }

            if (expense <= 450 && age == "28")
            {
                Console.WriteLine("For a 28 year old, you are within your budget. Good job!");
            }
            else if (expense > 450 && age == "28")
            {
                Console.WriteLine("For a 28 year old, you are spending too much. Please reflect on what you have been spending your money on recently.");
            }

            if (expense <= 500 && age == "29")
            {
                Console.WriteLine("For a 29 year old, you are within your budget. Good job!");
            }
            else if (expense > 500 && age == "29")
            {
                Console.WriteLine("For a 29 year old, you are spending too much. Please reflect on what you have been spending your money on recently.");
            }

            if (expense <= 550 && age == "30")
            {
                Console.WriteLine("For a 30 year old, you are within your budget. Good job!");
            }
            else if (expense > 550 && age == "30")
            {
                Console.WriteLine("For a 30 year old, you are spending too much. Please reflect on what you have been spending your money on recently.");
            }

            Console.Write("\n");

            //Console.WriteLine("Hello World!");

            Console.WriteLine("Press any key to exit the program");
        }
    }
}
