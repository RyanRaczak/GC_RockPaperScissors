using System;

namespace GC_RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!\n");
            RPSApp App = new RPSApp();
            App.Play();
        }
    }
}
