using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber2
{
    class Round
    {
        static Random randomNum = new Random();
        static int winningNum = randomNum.Next(0, 10);
        public int steps = 0;
        public int guess;
        static int roundNum = 0;

        public Round()
        {
            roundNum++;
            winningNum = randomNum.Next(0, GetMaxNumber());
            steps = 0;
            guess = -1;
            Console.WriteLine("[ Game " + roundNum + " ]");
         //   Console.WriteLine("* Winning number: " + winningNum);
        }

        public int GetMaxNumber()
        {
            return 10 + (10 * (roundNum-1));
        }

        public void Attempt()
        {
            try
            {
                Console.Write("Guess the number from 0 to {0}: ", GetMaxNumber());
                guess = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
            }
            steps++;
            Console.WriteLine();
        }

        public bool CheckGuess()
        {
            if (guess != winningNum)
            {
                if (guess < 0 || guess > GetMaxNumber())
                {
                    Console.WriteLine("Wrong guess! Remember that you are supposed to guess a number from 0 to {0}. Try again.", GetMaxNumber());
                }
                else if (guess > winningNum)
                {
                    Console.WriteLine("Wrong guess! Your number was too high! Try again.");
                }
                else if (guess < winningNum)
                {
                    Console.WriteLine("Wrong guess! Your number was too low! Try again.");
                }
                return false;
            }
            else
            {
                Console.WriteLine("You won the game!\nIt took you " + steps + " guess(es) to win this time.");
                return true;
            }
        }
    }
}