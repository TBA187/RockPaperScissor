using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class controller
    {
        model mdl = new model();
        Random rand = new Random();

        public void SetNames(string name1, string name2)
        {
            mdl.name1 = name1;
            mdl.name2 = name2;
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
                for (int i = 1; i < 6; i++)
                {
                    mdl.val1 = rand.Next(1, 3);
                    mdl.val2 = rand.Next(1, 3);
                    string draw = "";

                    if (mdl.val1 == 1 && mdl.val2 == 2)
                    {
                        mdl.points2 += 1;
                    }
                    else if (mdl.val1 == 1 && mdl.val2 == 3)
                    {
                        mdl.points1 += 1;
                    }
                    else if (mdl.val1 == 2 && mdl.val2 == 1)
                    {
                        mdl.points1 += 1;
                    }
                    else if (mdl.val1 == 2 && mdl.val2 == 3)
                    {
                        mdl.points2 += 1;
                    }
                    else if (mdl.val1 == 3 && mdl.val2 == 1)
                    {
                        mdl.points2 += 1;
                    }
                    else if (mdl.val1 == 3 && mdl.val2 == 2)
                    {
                        mdl.points1 += 1;
                    }
                    else
                    {
                        mdl.points1 += 0;
                        mdl.points2 += 0;
                        draw = " uafgjort";
                    }

                    Console.WriteLine("Runde: " + i + draw);
                    Console.WriteLine(mdl.name1 + " har: " + mdl.points1);
                    Console.WriteLine(mdl.name2 + " har: " + mdl.points2 + "\n");

                }
                Console.ReadKey();
            }
        }
    }
}
