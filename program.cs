using System;

namespace FirstConsoleProject
{
    class MainClass
    {
        public static void Main(string[] args) // This is a method, called 'main'. It is called when the program starts.
        {
            Start:
            Random diceRoll = new Random(); 

            int numberOfAttempts = 0;
            int attempt = 0;

            while (attempt != 6) {
                attempt = diceRoll.Next(1, 7);
                Console.WriteLine("Tom rolled: " +attempt+ ". "); 
                numberOfAttempts++;
            }

            Console.WriteLine("It took Tom " + numberOfAttempts + " attempts to roll a 6");
            Console.ReadKey();
            goto Start;

        }

    }
}
