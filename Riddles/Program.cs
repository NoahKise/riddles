using Riddles.Models;
using Riddles.UserInterfaceModels;

namespace Riddles;

class Program
{
    static void Main()
    {
        ShowSpinner();
      Riddle first = new("What has a trunk but no key?", "elephant");
      Riddle second = new("There are three men an a boat with a pack of cigarettes and no matches. How did they manage to smoke?", "lighter");
      Riddle third = new("What room can none enter", "mushroom");
      
      RunGame();       
    }
    static void RunGame()
        {
        // Console.BackgroundColor = ConsoleColor.Blue;
        // Console.ForegroundColor = ConsoleColor.White;
        bool playAgain = true;
        while (playAgain)
        {

            List<Riddle> riddles = Riddle.GetAll();
            Console.WriteLine(Jackal.AnubisBanner);
            Console.WriteLine($"There are {riddles.Count} riddles");
            Console.WriteLine("You must answer them all to pass");
            Console.WriteLine("--------------------------------------------------");
            for (int i = 0; i < riddles.Count; i++)
            {
                Console.WriteLine($"~~{riddles[i].Question}~~");
                Console.WriteLine("--------------------------------------------------");
                string userAnswer1 = Console.ReadLine().ToLower();
                if (userAnswer1.Contains(riddles[i].Answer))
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("~~Ah, a lucky guess~~");
                    if (i == 2) 
                    {
                      playAgain = false;
                      WinGame();
                    }
                }
                else
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("~~Nope, sorry you lose.  Play again? (y or n)~~");
                    Console.WriteLine("--------------------------------------------------");
                    string userInput = Console.ReadLine().ToLower();
                    if (userInput == "y")
                    {
                      playAgain = true;
                      break;
                    }
                    else
                    {
                        playAgain = false;
                        Console.WriteLine("~~Thanks for playing goodbye!~~");
                        break;
                    }
                }
            }
        }
        
    }

    static void ShowSpinner()
    {
        int counter = 0;
        for (int i = 0; i < 50; i++)
        {
            switch (counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            counter++;
            Thread.Sleep(100);
        }
    }

    static void WinGame() {
      Console.WriteLine("Congratulations... you have answered my riddles...\n");
      Console.WriteLine("Your prize... if you should choose to collect it... awaits\n");
      Console.WriteLine("Collect your prize (y)");
      Console.WriteLine("Forgo worldly possesions (any key)");
      string userInput = Console.ReadLine().ToLower();
      if (userInput == "y") {
        Console.WriteLine("Your prize... is here...");
        Console.WriteLine(Jackal.TreasureChest);
        Console.WriteLine("Come closer...(press any key to continue)");
        Console.ReadKey();
        Console.WriteLine("HAH!\nYou're still attached to the world of mortal posessions...\nPlay my game again see if you have learned anything...");
        RunGame();
      } 
      else 
      {
        Console.WriteLine("Well, I'll be.\n");
        Console.WriteLine("Your soul has passed my judgement, you may exit my application.");
      }
    }
}
