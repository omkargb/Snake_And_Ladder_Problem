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
            Console.WriteLine(" Player Position : "+playerPosition);
            
            Random random = new Random();
            int diceValue = random.Next(1,7);     // generates between 1 to 6
            Console.WriteLine(" Rolling a die... Die Value is : "+diceValue);

            Console.WriteLine("\n Deciding options : No Play, Ladder or Snake ...");
            int option = random.Next(0, 3);     // generates between 0 to 2
            if (option == 1)
            {
                playerPosition = playerPosition + diceValue;
                Console.WriteLine(" Ladder : +" +diceValue );
                Console.WriteLine(" Player Position : " + playerPosition);
            }
            else if (option == 2)
            {
                Console.WriteLine(" Snake : -" + diceValue);
                if (playerPosition < diceValue)
                {
                    playerPosition = 0;
                }
                else
                {
                    playerPosition = playerPosition - diceValue;
                }
                Console.WriteLine(" Player Position : " + playerPosition);
            }
            else 
            {
                Console.WriteLine(" No Play");
            }
        }
    }
}
