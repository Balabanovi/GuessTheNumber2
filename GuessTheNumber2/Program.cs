using System;

namespace GuessTheNumber2 
{
    class Program
    {
        static void Main(string[] args)
        {
            initGame();

            Console.ReadLine(); 
        }

        static void initGame()
        {
            Console.WriteLine("The Greatest Guess the Number Game of All Time. PART 2!\nYour goal is to guess the number from 0 to 10.\nWith each successive game, the number range will increase.\nThe game will give you a hint if you fail to guess.");
            nextGame();
        }

        static void nextGame()
        {
            Console.WriteLine();

            Round newRound = new Round();
            bool result;

            do
            {
                newRound.Attempt();
                result = newRound.CheckGuess();
            } while (!result);

            playAgain();
        }


        static void playAgain()
        {
            Console.Write("Play again? Y/N: ");
            var userEntry = Console.ReadLine();
            char newGame = (!String.IsNullOrEmpty(userEntry)) ? Convert.ToChar(userEntry) : ' ';
            if (newGame == 'Y' || newGame == 'y')
            {
                Console.WriteLine();
                Console.WriteLine("------------------------");
                Console.WriteLine();

                nextGame();
            }
            else if (newGame == 'N' || newGame == 'n')
            {
                Environment.Exit(0);
            }
            else
            {
                playAgain();
            }
        }
    }
}