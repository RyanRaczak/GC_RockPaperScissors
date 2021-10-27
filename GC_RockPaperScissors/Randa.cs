using System;
using System.Collections.Generic;
using System.Text;

namespace GC_RockPaperScissors
{
    class Randa : Player
    {
        public Randa() : base("Randa") { }

        public override RPS GenerateRPS()
        {
            Random RNG = new Random();
            int toss = RNG.Next(0, 3);
            switch (toss)
            {
                case 0:
                    return RPS.Rock;
                case 1:
                    return RPS.Paper;
                case 2:
                    return RPS.Scissors;
                default:
                    return RPS.Rock;
            }
        }
    }
}
