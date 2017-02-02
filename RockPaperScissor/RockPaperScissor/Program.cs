using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace RockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 = rock
            // 2 = paper
            // 3 = scizor

            Random rand = new Random();
            model mdl = new model();

            while (true)
            {

                Console.WriteLine("1. Login \n 2. Start game \n 3. Terminate game");
                int val = int.Parse(Console.ReadLine());


                if (val == 1)
                {
                    Console.WriteLine("Angiv navn på første spiller:");
                    string name1 = Console.ReadLine();
                    Console.WriteLine("Angiv navn på anden spiller:");
                    string name2 = Console.ReadLine();

                    mdl.name1 = name1;
                    mdl.name2 = name2;
                }
                else if (val == 2)
                {
                    for (int i = 1; i < 5; i++)
                    {
                        if (mdl.name1 != "" && mdl.name2 != "")
                        {
                            mdl.val1 = rand.Next(1, 3);
                            mdl.val2 = rand.Next(1, 3);

                            if (mdl.val1 == 1 && mdl.val2 == 2)
                            {
                                mdl.points2 += 1;
                                Console.WriteLine("Player: " + mdl.name1);
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
                                Console.WriteLine("DRAW!");
                                Console.ReadKey();
                            }

                            Console.WriteLine(mdl.name1 + " has: " + mdl.points1);
                            Console.WriteLine(mdl.name2 + " has: " + mdl.points2);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Please choose 1. option first!");
                            Console.ReadKey();
                        }


                    }
                }
                else
                {
                    Console.WriteLine("Du skal først angive navn på spillere.");
                }
            }

        }
    }
}