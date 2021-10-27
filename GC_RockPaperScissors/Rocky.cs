using System;
using System.Collections.Generic;
using System.Text;

namespace GC_RockPaperScissors
{
    class Rocky : Player
    {
        public Rocky() : base("Rocky") { }
        public override RPS GenerateRPS()
        {
            return RPS.Rock;
        }
    }
}
