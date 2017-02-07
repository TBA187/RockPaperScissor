using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace RockPaperScissor
{

    class controller
    {
        model mdl = new model();
        Random rand = new Random();
        string player1move = "";
        string player2move = "";

        string validationStatus;
        public string SetNames(string name1, string name2)
        {
            Contract.Requires(!string.IsNullOrEmpty(name1), "Navn må ikke være tomt!");
            Contract.Requires<ArgumentNullException>(!string.IsNullOrEmpty(name1), "Exception!!");

            Contract.Requires(!string.IsNullOrEmpty(name2), "Navn må ikke være tomt!");
            Contract.Requires<ArgumentNullException>(!string.IsNullOrEmpty(name2), "Exception!!");

            Contract.Ensures(Contract.Result<string>() != "");

            validationStatus = Contract.Result<string>();

            if (name1 == "" || name2 == "")
            {
                validationStatus = "Navn må ikke være tomt!";
            }
            else
            {
                mdl.name1 = name1;
                mdl.name2 = name2;
            }

            return validationStatus;
        }

        public void Play()
        {

            mdl.points1 = 0;
            mdl.points2 = 0;

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
                for (int i = 1; i < 6; i++)
                {
                    mdl.val1 = rand.Next(1, 3);
                    mdl.val2 = rand.Next(1, 3);
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

                    Console.WriteLine("Runde: " + i + draw);
                    Console.WriteLine("Player " + mdl.name1 + " " + player1move + " and " + mdl.name2 + " " + player2move);
                    Console.WriteLine(mdl.name1 + " har: " + mdl.points1);
                    Console.WriteLine(mdl.name2 + " har: " + mdl.points2 + "\n");

                }
                Console.ReadKey();
            }
        }
    }
}