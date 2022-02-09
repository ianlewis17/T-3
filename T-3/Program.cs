using System;

namespace T_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            // Program Start

            // To provide flexibility, ask the user to enter a CAD increment value, an integer value between 5 and 25 
            Console.WriteLine("Please enter a CAD increment value between 5 and 25: ");
            // Get the user's input
            string userInput = Console.ReadLine();
            // Conver the user's input to an integer
            int userInputint = int.Parse(userInput);
            // Display the CAD Increment Value = YY
            Console.WriteLine("CAD Increment Value = " + userInputint);
            // Display the first line of the table
            Console.WriteLine("CAD		US$");

            // initial CAD value
            float CAD = 0f;
            // conversion rate
            float conversion_rate = 0.792367f;
           

            // begin while loop
            while (CAD < 200)
            {
                // calculate USD value
                float USD = CAD * conversion_rate;
                // display USD on the console
                Console.WriteLine(CAD + "	" + USD);

                // incremented CAD based on the user input
                CAD = CAD + userInputint;
            }

        }
    }
}
