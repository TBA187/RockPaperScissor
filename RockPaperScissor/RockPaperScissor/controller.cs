using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace RockPaperScissor
{

    class Controller
    {
        model mdl = new model();
        Random rand = new Random();
        Model.Player player;
        string player1move = "";
        string player2move = "";    

        string validationStatus;
        public string SetNames(string inputPlayerName)
        {
            Contract.Requires(!string.IsNullOrEmpty(inputPlayerName), "Navn må ikke være tomt!");
            //Contract.Requires<ArgumentNullException>(!string.IsNullOrEmpty(name1), "Exception!!");

            //Contract.Requires(!string.IsNullOrEmpty(name2), "Navn må ikke være tomt!");
            //Contract.Requires<ArgumentNullException>(!string.IsNullOrEmpty(name2), "Exception!!");

            Contract.Ensures(Contract.Result<string>() != "");

            validationStatus = Contract.Result<string>();
            player = new Model.Player();

            if (inputPlayerName == "")
            {
                validationStatus = "Navn må ikke være tomt!";
            }
            else
            {
                try
                {
                    player.PlayerName = inputPlayerName;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return validationStatus;
        }

        public void ResetPoints() // This is a Command
        {
            player = new Model.Player();
            player.Credential.Points = 0;
        }

        public void SetMoves(int playerMove1, int playerMove2) // This is a Command
        {
            mdl.val1 = playerMove1;
            mdl.val2 = playerMove2;
        }

        List<int> listOfMoves;
        public List<int> ReturnMoves() //This is the Query
        {
            listOfMoves = new List<int>();

            listOfMoves.Add(mdl.val1);
            listOfMoves.Add(mdl.val2);

            return listOfMoves;
        }

        public void Play()
        {
            if (string.IsNullOrEmpty(mdl.name1) && string.IsNullOrEmpty(mdl.name2))
            {
                Console.WriteLine("Angiv venligst navn på begge deltagere!");
                Console.ReadKey();
            }
            else
            {
                // 1 = rock
                // 2 = paper
                // 3 = scizor
                    string draw = "";

                    if (mdl.val1 == 1 && mdl.val2 == 2)
                    {
                        mdl.points2 += 1;
                        player1move = "Rock";
                        player2move = "Paper";
                    }
                    else if (mdl.val1 == 1 && mdl.val2 == 3)
                    {
                        mdl.points1 += 1;
                        player1move = "Rock";
                        player2move = "Scissor";
                    }
                    else if (mdl.val1 == 2 && mdl.val2 == 1)
                    {
                        mdl.points1 += 1;
                        player1move = "Paper";
                        player2move = "Rock";
                    }
                    else if (mdl.val1 == 2 && mdl.val2 == 3)
                    {
                        mdl.points2 += 1;
                        player1move = "Paper";
                        player2move = "Scissor";
                    }
                    else if (mdl.val1 == 3 && mdl.val2 == 1)
                    {
                        mdl.points2 += 1;
                        player1move = "Scissor";
                        player2move = "Paper";
                    }
                    else if (mdl.val1 == 3 && mdl.val2 == 2)
                    {
                        mdl.points1 += 1;
                        player1move = "Scissor";
                        player2move = "Rock";
                    }
                    else
                    {
                        mdl.points1 += 0;
                        mdl.points2 += 0;
                        draw = " uafgjort";
                    }

                    Console.WriteLine("Runde: " + draw);
                    Console.WriteLine("Player " + mdl.name1 + " " + player1move + " and " + mdl.name2 + " " + player2move);
                    Console.WriteLine(mdl.name1 + " har: " + mdl.points1);
                    Console.WriteLine(mdl.name2 + " har: " + mdl.points2 + "\n");

                Console.ReadKey();
            }
        }
    }
}