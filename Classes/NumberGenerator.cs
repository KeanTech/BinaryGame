using System;
namespace BinaryGame
{
    class NumberGenerator
    {
        int number;
        public int Number(string Mode)
        {
            
            Random rng = new Random();
            if (Mode == "easy")
            {
                number = rng.Next(8, 31);
            }
            if (Mode == "medium")
            {
                number = rng.Next(32, 63);
            }
            if (Mode == "hard")
            {
               number = rng.Next(64, 128);
            }
            return number;
        }
    }

}
