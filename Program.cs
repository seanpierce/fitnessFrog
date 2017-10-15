using System;

namespace SeanPierce.FitnessFrog
{
  class Program
  {
    static void Main()
    {
      double runningTotal = 0;
      bool keepGoing = true;

      while (keepGoing)
      {
        // Prompt user for minutes exercised
        Console.Write("Enter how many minutes you exercised, or type \"quit\" to exit: ");

        string entry = Console.ReadLine();

        if (entry.ToLower() == "quit")
        {
          keepGoing = false;
        }
        else
        {

          try
          {
            double minutes = double.Parse(entry);

            if (minutes <= 0)
            {
              Console.WriteLine(minutes + " is not an accepable value.");
              continue;
            }
            else if (minutes <= 10)
            {
              Console.WriteLine("Better than nothing, right?");
            }
            else if (minutes <= 30)
            {
              Console.WriteLine("Way to go!");
            }
            else if (minutes <= 60)
            {
              Console.WriteLine("You're doing great!");
            }
            else
            {
              Console.WriteLine("Holy Cow! Slow down!");
            }
            // Add minutes exercised to total
            runningTotal = runningTotal + minutes;
          }
          catch (FormatException)
          {
            Console.WriteLine("That is not valid input.");
            continue;
          }

          // Display total minutes exercised to the screen
          Console.WriteLine("You've exercised for " + runningTotal + " minutes.");
          // Repeat until user quits
        }

      }
      Console.Write("Goodbye!");
    }
  }
}
