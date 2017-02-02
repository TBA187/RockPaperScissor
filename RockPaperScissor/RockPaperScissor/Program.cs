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
            controller con = new controller();

            // 1 = rock
            // 2 = paper
            // 3 = scizor

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

                    con.SetNames(name1, name2);
                }
                else if (val == 2)
                {
                    con.Play();
                }

                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}