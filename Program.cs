using System;

namespace SeanPierce.FitnessFrog
{
  class Program
  {
    static void Main()
    {
      int runningTotal = 0;
      bool continueGoing = true;

      while (continueGoing)
      {
        // Prompt user for minutes exercised
        Console.Write("Enter how many minutes you exercised, or type \"quit\" to exit: ");

        string entry = Console.ReadLine();

        if (entry == "quit")
        {
          continueGoing = false;
        }
        else
        {
          int minutes = int.Parse(entry);

          if (minutes <= 10)
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

          // Display total minutes exercised to the screen
          Console.WriteLine("You've exercised for " + runningTotal + " minutes.");
          // Repeat until user quits
        }

      }
      Console.Write("Goodbye!");
    }
  }
}
