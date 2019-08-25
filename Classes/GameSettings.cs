using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGame
{
    class GameSettings
    {
        public int Difficulty;
        private string[,] difficilty = { 
            { "easy" ,"medium", "hard" },
            {   "0"  ,  "1"   ,   "2"  }
        };


        public int GameMode(string Input)
        {
            if (int.TryParse(Input, out int input) == true || input == 0)
            {
                if (string.IsNullOrEmpty(Input) == true)
                {
                    Console.WriteLine("No gamemode was selected !\n" +
                        "GameMode set to: Easy");
                }
                Difficulty = int.Parse(difficilty[1, input]);
            }
            else if (input == 1)
            {
                Difficulty = int.Parse(difficilty[1, input]);
            }
            else if (input == 2)
            {
                Difficulty = int.Parse(difficilty[1, input]);
            }
            return Difficulty;
        }
        public string Modes()
        {
            string modes = $"{difficilty[0, 0]} = {difficilty[1, 0]}\n" +
                           $"{difficilty[0, 1]} = {difficilty[1, 1]}\n" +
                           $"{difficilty[0, 2]} = {difficilty[1, 2]}";
            return modes;
        }
    }
}