using Riddles.Models;
using Riddles.UserInterfaceModels;

namespace Riddles;

class Program
{
    static void Main()
    {
      Riddle first = new("What has a trunk but no key?", "elephant");
      Riddle second = new("There are three men an a boat with a pack of cigarettes and no matches. How did they manage to smoke?", "lighter");
      Riddle third = new("What room can none enter", "mushroom");
      
      RunGame();       
    }
    static void RunGame()
        {
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
                }
                else
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("~~Nope, sorry you lose.  Play again? (y or n)~~");
                    Console.WriteLine("--------------------------------------------------");
                    string userInput = Console.ReadLine().ToLower();
                    if (userInput == "y")
                    {
                        break;
                    }
                    else
                    {
                        playAgain = false;
                        break;
                    }
                }
            }
        }
        Console.WriteLine("~~Thanks for playing goodbye!~~");
    }
}
