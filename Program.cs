using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnessrevisit
{
    class Program
    {
        static void Main()
        {
            int runningTotal = 0;
            bool keepGoing = true;

            while (keepGoing)
            {
                //prompt the user for minutes exercised
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                string entry = Console.ReadLine();

                if (entry == "quit")
                {
                    keepGoing = false;
                }

                else
                {
                    int minutes = int.Parse(entry);
                    runningTotal = runningTotal + minutes;

                    //add min exercised to total
                    //display minutes exercised to screen
                    Console.WriteLine("You've exercised " + runningTotal + " minutes");
                }
                    //repeat program until user quits
                
            }
            Console.WriteLine("Goodbye");

        }   
    }

    //add more questions, more interaction. coffee app as example
}
