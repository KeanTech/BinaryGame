using System;
using BinaryGame;
namespace BinaryGame
{
    class Game
    {
        GameSettings GetGameSettings = new GameSettings();
        
        int number;
        private bool answer;
        public int GetDecimal(int Mode)
        {
            Random rng = new Random();
            if (Mode == 0)
            {
                number = rng.Next(8, 31);
            }
            if (Mode == 1)
            {
                number = rng.Next(32, 63);
            }
            if (Mode == 2)
            {
               number = rng.Next(64, 128);
            }
            return number;
        }
        public int ConvertToDecimal(int binary)
        {
            int dec = 0, pow = 1, rem;

            while (binary > 0)
            {
                rem = binary % 10;
                dec = dec + rem * pow;
                binary = binary / 10;
                pow = pow * 2;
            }
            return dec;
        }
        public bool Answer(string Input)
        {
            GameSettings game = new GameSettings();
            int dec;
            dec = ConvertToDecimal(int.Parse(Input));

            if(dec == GetDecimal(game.Difficulty))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            return answer;
        }
    }
}
