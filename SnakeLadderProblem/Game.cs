using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderProblem
{
    class Game
    {
        public void player()
        {
            int playerPosition = 0;
            Random random = new Random();

            while (playerPosition < 100)
            {
                if (playerPosition>100)
                {
                    playerPosition = 100;
                    Console.WriteLine(" Winning position reached..");
                }

                int diceValue = random.Next(1, 7);     // generates between 1 to 6
                Console.Write(" Rolling a die... Die Value is : " + diceValue+ "  | Option");

                int option = random.Next(0, 3);     // generates between 0 to 2
                if (option == 1)
                {
                    playerPosition = playerPosition + diceValue;
                    Console.WriteLine(" --> Ladder : +" + diceValue+ "  |  Player Position : " + playerPosition);
                }
                else if (option == 2)
                {
                    if (playerPosition < diceValue)
                    {
                        playerPosition = 0;
                    }
                    else
                    {
                        playerPosition = playerPosition - diceValue;
                    }
                    Console.WriteLine(" --> Snake  : -" + diceValue+ "  |  Player Position : " + playerPosition);
                }
                else
                {
                    Console.WriteLine(" --> No Play");
                }
            }
        }
    }
}
