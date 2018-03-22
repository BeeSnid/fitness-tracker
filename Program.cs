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
            var runningTotal = 0.0;

            while (true)  //the loop will run until the break statement is hit
            {
                //prompt the user for minutes exercised
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                var entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    break; //this tells code to break out of loop and jump down to "goodbye"
                }

                
                
                    

                    try
                    {
                        var minutes = double.Parse(entry);
                        if (minutes <= 0)
                        {
                            Console.WriteLine(minutes + " is not an acceptable value.");
                            continue;
                        }
                        else if (minutes <= 10)
                        {
                            Console.WriteLine("Better than nothing!");
                        }
                        else if (minutes <= 30)
                        {
                            Console.WriteLine("Way to go, hot stuff!");
                        }
                        else if (minutes <= 60)
                        {
                            Console.WriteLine("You must be a ninja warrior!");
                        }
                        else
                        {
                            Console.WriteLine("Now you're just showing off!");
                        }





                        runningTotal += minutes;

                        //add min exercised to total
                        //display minutes exercised to screen
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That is not valid input.");
                        continue;
                    }
                    
                    Console.WriteLine("You've exercised " + runningTotal + " minutes");
                
                    //repeat program until user quits
                
            }
            Console.WriteLine("Goodbye");

        }   
    }

    //add more questions, more interaction. coffee app as example
}
