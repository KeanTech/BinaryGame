using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGame
{
    class Game
    {
        public string GameMode { get; set; }
        Player playerStats = new Player();
        
        bool Bonus = false;
        

        public int NumberGenerator()
        {
            NumberGenerator GetNumber = new NumberGenerator();
            if (string.IsNullOrEmpty(GameMode))
            {
                GameMode = "easy";    
            }
            return GetNumber.Number(GameMode);
        }

        public void NewGame(string PlayerName)
        {
            Player player = new Player
            {
                Name = PlayerName
            };
            


        }
        public void Points(bool Anwser)
        {
            Binary answer = new Binary();
            if (Anwser == false)
            {
                playerStats.Points -= 1;
                Bonus = false;
            }
            if (Anwser && Bonus == true)
            {
                playerStats.Points += 2;
            }
            else if (Anwser == true)
            {
                playerStats.Points += 1;
                Bonus = true;
            }
        }

    }
}