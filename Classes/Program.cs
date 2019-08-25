using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BinaryGame
{
    class Program
    {

        static void Main(string[] args)
        {
            //Old Game
            #region
            ////Will make a set a three rnd's
            //NumberGenerator newnumber = new NumberGenerator();
            ////Will convert binary to decimal number
            //Binary binaryconverter = new Binary();
            ////Will make a new player
            //Player player = new Player();

            //int quiznumber;
            //string input;
            //char quit; 

            //bool Bonus = false;
            //bool GameRunning = true;

            //Console.WriteLine("Hello, i am the automatic numbergen to binary machine or NTBM");
            //Console.WriteLine("Press Enter To Continue");
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine("Enter Playername:");
            //input = Console.ReadLine();

            //player.Round = 1;
            //quiznumber = newnumber.GenerateNum(player.Score);
            //player.Name = input;

            ////Game loop will keep the user in the loop unless they enter nothing or they type q
            //while (GameRunning == true)
            // {
            //    player.Result = player.Score + player.Bonus;
            //    if (player.Round >= 10)
            //    {
            //        Console.WriteLine("Nice you did it your score is: {0} you got {1} bonus points", player.Result, player.Bonus);
            //        Console.ReadKey();
            //        GameRunning = false;
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine("PlayerName: {0} \nYour score is {1} \nRound {2} ", player.Name, player.Score, player.Round);
            //        Console.WriteLine(" {0} Here is your Decimal, Now give me a binary ;)", quiznumber);
            //        input = Console.ReadLine();
            //        input.ToLower();
            //    }
            //    //This loop is the rounds 
            //    bool GameRound = true;
            //    while (GameRound == true)
            //    {
            //        if (Int32.TryParse(input, out int binary))
            //        {
            //            player.Result = player.Score + player.Bonus;
            //            if (quiznumber != binaryconverter.ToDecimal(binary))
            //            {
            //                // Like !=  
            //                if (!(player.Score == 0))
            //                {
            //                    player.Score = player.Score - 1;
            //                    player.Round = player.Round + 1;

            //                    Console.Clear();
            //                    Console.WriteLine("PlayerName: {1} \nYour score is {0} \nRound {2} ", player.Result, player.Round);
            //                    Console.WriteLine("Wrong Try Again type quit to end.. Your decimal is {0}", quiznumber);

            //                    input = Console.ReadLine();
            //                    Int32.TryParse(input, out binary);
            //                }
            //                if (input == "quit")
            //                {
            //                    GameRunning = false;
            //                }
            //                if (player.Round == 10)
            //                {
            //                    Console.WriteLine("Nice you did it your score is: {0} you got {1} bonus points", player.Result, player.Bonus);
            //                    Console.ReadKey();
            //                    GameRunning = false;
            //                    GameRound = false;
            //                }
            //                else
            //                {
            //                    player.Round = player.Round + 1;

            //                    Console.Clear();
            //                    Console.WriteLine("PlayerName: {0} \nYour score is {1} \nRound {2} ", player.Name, player.Result, player.Round);
            //                    Console.WriteLine("Wrong Try Again type quit to end.. Your decimal is {0}", quiznumber);
            //                    Bonus = false;
            //                    input = Console.ReadLine();
            //                    Int32.TryParse(input, out binary);
            //                }
            //            }
            //            if (quiznumber == binaryconverter.ToDecimal(binary))
            //            {
            //                if (player.Round == 10)
            //                {
            //                    Console.WriteLine("Nice you did it your score is: {0} you got {1} bonus points", player.Result, player.Bonus);
            //                    Console.ReadKey();
            //                    GameRunning = false;
            //                    GameRound = false;
            //                }
            //                if (Bonus == true)
            //                {
            //                    Console.WriteLine("Two times in a row Nice");
            //                    quiznumber = newnumber.GenerateNum(player.Score);
            //                    Console.ReadKey();
            //                    player.Score = player.Score + 2;
            //                    player.Round = player.Round + 1;
            //                    player.Bonus = player.Bonus + 1;
            //                    GameRound = false;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Woohuuu You Got It Right");
            //                    player.Score = player.Score + 1;
            //                    player.Round = player.Round + 1;
            //                    quiznumber = newnumber.GenerateNum(player.Score);
            //                    Console.ReadKey();

            //                    GameRound = false;
            //                    Bonus = true;
            //                }
            //            }
            //        }
            //        else // Quit option
            //        {
            //            Console.WriteLine("did you mean quit? y/n");

            //            input = Console.ReadLine();
            //            quit = Convert.ToChar(input);

            //            if (quit == 'y' && input.Length > 0)
            //            {
            //                GameRound = false;
            //                GameRunning = false;
            //            }
            //            else
            //            {
            //                GameRound = false;
            //                GameRunning = true;
            //            }
            //        }

            //    }
            //}

            #endregion 


            //Test

            Game game = new Game();

            while (game.NumberGenerator() > 0)
            {
                Console.WriteLine(game.NumberGenerator());
                
            }
        }
    }
}
