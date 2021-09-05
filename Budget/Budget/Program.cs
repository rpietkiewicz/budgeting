using System;

namespace Budget
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("###################################################\n");
                Console.WriteLine("----------You are now using Budgeting--------------\n");
                Console.WriteLine("###################################################\n");
                Console.WriteLine("**********Press any key to continue****************\n");
                Console.ReadLine();

                Console.Write("Please enter in your total weekly expenses: ");
                int expense = Int32.Parse(Console.ReadLine());

                Console.Write("\n");

                Console.Write("Please enter in your age in the range of 24 - 30 years old: ");
                string age = Console.ReadLine();
                //int yourAge;
                Console.Write("\n");

                /*if (age != "24")
                    throw new ArgumentOutOfRangeException("Please enter in a number that is between 24 and 30.");
                if (age != "25")
                    throw new ArgumentOutOfRangeException("Please enter in a number that is between 24 and 30.");
                if (age != "26")
                    throw new ArgumentOutOfRangeException("Please enter in a number that is between 24 and 30.");
                if (age != "27")
                    throw new ArgumentOutOfRangeException("Please enter in a number that is between 24 and 30.");
                if (age != "28")
                    throw new ArgumentOutOfRangeException("Please enter in a number that is between 24 and 30.");
                if (age != "29")
                    throw new ArgumentOutOfRangeException("Please enter in a number that is between 24 and 30.");
                if (age != "30")
                    throw new ArgumentOutOfRangeException("Please enter in a number that is between 24 and 30.");*/

                Console.WriteLine("//////Calculation process complete. Press any key to see your result//////");

                Console.Write("\n");

                Console.ReadLine();

                if (expense <= 250 && age == "24")
                {
                    Console.WriteLine("For a 24 year old, you are within your budget. Good job! Press any key to continue.");
                }
                else if (expense > 250 && age == "24")
                {
                    Console.WriteLine("For a 24 year old, you are spending too much. Please reflect on what you have been spending your money on recently. Press any key to continue.");
                }

                if (expense <= 300 && age == "25")
                {
                    Console.WriteLine("For a 25 year old, you are within your budget. Good job! Press any key to continue.");
                }
                else if (expense > 300 && age == "25")
                {
                    Console.WriteLine("For a 25 year old, you are spending too much. Please reflect on what you have been spending your money on recently. Press any key to continue.");
                }

                if (expense <= 350 && age == "26")
                {
                    Console.WriteLine("For a 26 year old, you are within your budget. Good job! Press any key to continue.");
                }
                else if (expense > 350 && age == "26")
                {
                    Console.WriteLine("For a 26 year old, you are spending too much. Please reflect on what you have been spending your money on recently. Press any key to continue.");
                }

                if (expense <= 400 && age == "27")
                {
                    Console.WriteLine("For a 27 year old, you are within your budget. Good job! Press any key to continue.");
                }
                else if (expense > 400 && age == "27")
                {
                    Console.WriteLine("For a 27 year old, you are spending too much. Please reflect on what you have been spending your money on recently. Press any key to continue.");
                }

                if (expense <= 450 && age == "28")
                {
                    Console.WriteLine("For a 28 year old, you are within your budget. Good job! Press any key to continue.");
                }
                else if (expense > 450 && age == "28")
                {
                    Console.WriteLine("For a 28 year old, you are spending too much. Please reflect on what you have been spending your money on recently. Press any key to continue.");
                }

                if (expense <= 500 && age == "29")
                {
                    Console.WriteLine("For a 29 year old, you are within your budget. Good job! Press any key to continue.");
                }
                else if (expense > 500 && age == "29")
                {
                    Console.WriteLine("For a 29 year old, you are spending too much. Please reflect on what you have been spending your money on recently. Press any key to continue.");
                }

                if (expense <= 550 && age == "30")
                {
                    Console.WriteLine("For a 30 year old, you are within your budget. Good job! Press any key to continue.");
                }
                else if (expense > 550 && age == "30")
                {
                    Console.WriteLine("For a 30 year old, you are spending too much. Please reflect on what you have been spending your money on recently. Press any key to continue.");
                }
            
            } catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            } /*catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }*/
            

            Console.ReadLine();

            //Console.Write("\n");

            //Console.WriteLine("Hello World!");

            Console.WriteLine("If you enjoyed using Budgeting please encourage your friends and family to use this program \n\n" +
                "If you would like to provide some feedback, please email robpietkiewicz14@gmail.com \n\n" +
                "Press any key to exit");
        }
    }
}
