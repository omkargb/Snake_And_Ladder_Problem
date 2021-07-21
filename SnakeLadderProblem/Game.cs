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
            Console.WriteLine(" Rolling a die. Value is : "+diceValue);
        }
    }
}
