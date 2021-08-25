using System;

namespace Unit1Deliverable1
{
    class Unit1Deliverable1
    {
        static void Main(string[] args)
        {
            // Display title 
            Console.WriteLine("-----------------------------------------------------------\r");
            string Header1 = "Deliverable One by April Carden for Oct 2021 C# After Hours\r";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Header1.Length / 2)) + "}", Header1));
            Console.WriteLine("-----------------------------------------------------------\r");
            string Header2 = "MilHip Conversion Console App\r";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Header2.Length / 2)) + "}", Header2));
            Console.WriteLine("-----------------------------------------------------------\r");

            //this while loop will restart the app if the user enters Yes
            while (true)

            {
                //Variables declaration
                int choice;
                double inch;
                double fidgetSpinner;
                double meme;
                double feet;

                // Ask the user to input the conversion type.
                Console.WriteLine("\n Choose the type of conversion you would like to do:\n \n 1 - Convert Inches to Fidget Spinner \n 2 - Convert Fidget Spinner to Inches \n 3 - Convert Feet to Meme \n 4 - Convert Meme to Feet \n");

                choice = int.Parse(Console.ReadLine());

                //Formula: 1 inch = 3.5 fidgit spinners and 1 foot = 5 memes

                switch (choice)
                {
                    case 1:
                        //Ask the user for an amount. Assume valid inputs
                        Console.Write("\n Enter the measurement in inches : ");
                        // Convert and store that amount from a string into a number
                        inch = double.Parse(Console.ReadLine());
                        //Convert the entered number to the correct new unit
                        fidgetSpinner = inch * 3.5;
                        //Output the result of the conversion along with the correct units
                        Console.WriteLine("\n {0} Inch Equals {1} Fidget Spinner", inch, fidgetSpinner);
                        break;
                    case 2:
                        Console.Write("\n Enter the measurement in Fidget Spinner : ");
                        fidgetSpinner = double.Parse(Console.ReadLine());
                        inch = fidgetSpinner / 3.5;
                        Console.WriteLine("\n {0} Fidget Spinner Equals {1} inch", fidgetSpinner, inch);
                        break;
                    case 3:
                        Console.Write("\n Enter the measurement in Feet : ");
                        feet = double.Parse(Console.ReadLine());
                        meme = feet * 5;
                        Console.WriteLine("\n {0} Feet Equals {1} Meme", feet, meme);
                        break;
                    case 4:
                        Console.Write("\n Enter the measurement in Meme : ");
                        meme = double.Parse(Console.ReadLine());
                        feet = meme / 5;
                        Console.WriteLine("\n {0} Meme Equals {1} Feet", meme, feet);
                        break;
                }
                Console.WriteLine("-----------------------------------------------------------\n");

                // 9 and 10 Ask user if they would like to do another calculation.
                Console.Write("Would you like to perform another conversion? Yes or No\n ");
                string again = Console.ReadLine();

                //If the user responds yes, loop back to the top of the program - this will allow yes or Yes
                if (again.ToLower() != "yes")

                //If the user responds with anything else, end the program
                {
                    Console.WriteLine("GoodBye");
                    System.Environment.Exit(0);
                }
            }
        }
    }
}