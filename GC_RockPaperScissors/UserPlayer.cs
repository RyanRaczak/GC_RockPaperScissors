using System;

namespace GC_RockPaperScissors
{
    class UserPlayer : Player
    {
        public int Wins { get; set; } = 0;
        public int Losses { get; set; } = 0;
        public UserPlayer()
        {
            Console.Write("\nPlease Enter your name: ");
            Name = Console.ReadLine();
        }
        public override RPS GenerateRPS()
        {
            Console.Write("\n::Please choose your toss::" +
                "\n1) Rock" +
                "\n2) Paper" +
                "\n3) Scissors" +
                "\n:: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    return RPS.Rock;
                case "2":
                    return RPS.Paper;
                case "3":
                    return RPS.Scissors;
                default:
                    Console.WriteLine("\n~INVALID INPUT: Please enter a number from the list~");
                    return GenerateRPS();
            }
        }

        public override string ToString()
        {
            return $"\nWins: {Wins}\nLosses: {Losses}";
        }
    }
}
