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
            Controller con = new Controller();
        

            while (true)
            {
                Console.WriteLine("1. Login \n2. Start game \n3. Terminate game");
                int val = int.Parse(Console.ReadLine());
                if (val == 1)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine("Angiv navn på første spiller:");
                        string name1 = Console.ReadLine();
                        con.SetNames(name1);
                    }
                    
                    //Console.WriteLine("Angiv navn på anden spiller:");
                    //string name2 = Console.ReadLine();

                    
                }
                else if (val == 2)
                {
                    con.ResetPoints();
                    Console.WriteLine("Player 1 plays");
                    int move1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Player 2 plays");
                    int move2 = int.Parse(Console.ReadLine());
                    con.SetMoves(move1, move2);
                    //con.Play(move1,move2); 
                }

                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}