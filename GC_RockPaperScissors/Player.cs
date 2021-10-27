using System;
using System.Collections.Generic;
using System.Text;

namespace GC_RockPaperScissors
{
    enum RPS
    {
        Rock,
        Paper,
        Scissors
    }

    abstract class Player
    {
        public string Name { get; set; }
        public RPS Toss { get; set; }
        public Player() { }
        public Player(string Name) { this.Name = Name; }

        public abstract RPS GenerateRPS();
    }
}
