using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor.Model
{
    public class Player
    {
        public string PlayerName { get; set; }

        public int PlayerID { get; set; }

        public Credential Credential { get; set; }

        public Player()
        {

        }
        public Player(string PlayerName, Credential Credential)
        {
            this.PlayerName = PlayerName;
            this.Credential.Move = Credential.Move;
            this.Credential.Points = Credential.Points;
        }
    }

}
