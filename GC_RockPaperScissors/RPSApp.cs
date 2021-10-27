using System;

namespace GC_RockPaperScissors
{
    class RPSApp
    {
        public void Play()
        {
            UserPlayer User = new UserPlayer();
            while (true)
            {
                Console.Write("\n::Please choose your opponent::" +
                    "\n1) Rocky" +
                    "\n2) Randa" +
                    "\n3) Both" +
                    "\n4) Exit" +
                    "\n:: ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        PlayRocky(User);
                        break;
                    case "2":
                        PlayRanda(User);
                        break;
                    case "3":
                        PlayTogether(User);
                        break;
                    case "4":
                        Console.WriteLine("\n::GOODBYE::");
                        return;
                    default:
                        Console.WriteLine("\n~INVALID INPUT: Please select a number from the list~");
                        continue;
                }
                Console.WriteLine(User);
            }
        }

        public UserPlayer PlayRocky(UserPlayer User)
        {
            Rocky rocky = new Rocky();
            User.Toss = User.GenerateRPS();
            rocky.Toss = rocky.GenerateRPS();
            Console.WriteLine($"\n{rocky.Name} threw: {rocky.Toss}\n{User.Name} threw: {User.Toss}");

            if (User.Toss.Equals(RPS.Paper))
            {
                Console.WriteLine("\n::YOU WIN!!!::");
                User.Wins++;
            }
            else if (User.Toss.Equals(RPS.Rock))
            {
                Console.WriteLine("\n::IT'S A DRAW!!::");
            }
            else if (User.Toss.Equals(RPS.Scissors))
            {
                Console.WriteLine("\n::YOU LOSE!!::");
                User.Losses++;
            }
            return User;
        }
        public UserPlayer PlayRanda(UserPlayer User)
        {
            Randa randa = new Randa();
            User.Toss = User.GenerateRPS();
            randa.Toss = randa.GenerateRPS();
            Console.WriteLine($"\n{randa.Name} threw: {randa.Toss}\n{User.Name} threw: {User.Toss}");

            if (User.Toss.Equals(RPS.Paper) && randa.Toss.Equals(RPS.Rock))
            {
                Console.WriteLine("\n::YOU WIN!!!::");
                User.Wins++;
            }
            else if (User.Toss.Equals(RPS.Rock) && randa.Toss.Equals(RPS.Scissors))
            {
                Console.WriteLine("\n::YOU WIN!!!::");
                User.Wins++;
            }
            else if (User.Toss.Equals(RPS.Scissors) && randa.Toss.Equals(RPS.Paper))
            {
                Console.WriteLine("\n::YOU WIN!!!::");
                User.Wins++;
            }
            else if (User.Toss == randa.Toss)
            {
                Console.WriteLine("\n::IT'S A DRAW!!::");
            }
            else
            {
                Console.WriteLine("\n::YOU LOSE!!::");
                User.Losses++;
            }
            return User;
        }
        public UserPlayer PlayTogether(UserPlayer User)
        {
            Console.WriteLine("\n::In this mode both Rocky and Randa will try to beat you::");
            Rocky Rocky = new Rocky();
            Randa Randa = new Randa();
            bool RockyElm = false;
            bool RandaElm = false;
            while (true)
            {
                User.Toss = User.GenerateRPS();
                Console.WriteLine($"\n{User.Name} toss: {User.Toss}");
                if (!RockyElm)
                {
                    Rocky.Toss = Rocky.GenerateRPS();
                    Console.WriteLine("\nRocky toss: Rock");
                }
                if (!RandaElm)
                {
                    Randa.Toss = Randa.GenerateRPS();
                    Console.WriteLine($"\nRanda toss: {Randa.Toss}");
                }

                if (!RockyElm)
                {
                    if (User.Toss.Equals(RPS.Paper))
                    {
                        Console.WriteLine("\n::ROCKY ELIMINATED!::");
                        RockyElm = true;
                    }
                    else if (User.Toss.Equals(RPS.Rock))
                    {
                        Console.WriteLine($"\n::{User.Name} DRAWS WITH ROCKY::");
                    }
                    else if (User.Toss.Equals(RPS.Scissors))
                    {
                        Console.WriteLine("\n::YOU LOSE!!::");
                        User.Losses++;
                        return User;
                    }

                }
                if (!RandaElm)
                {
                    if (User.Toss.Equals(RPS.Paper) && Randa.Toss.Equals(RPS.Rock))
                    {
                        Console.WriteLine("\n::RANDA ELIMINATED!::");
                        RandaElm = true;
                    }
                    else if (User.Toss.Equals(RPS.Rock) && Randa.Toss.Equals(RPS.Scissors))
                    {
                        Console.WriteLine("\n::RANDA ELIMINATED!::");
                        RandaElm = true;
                    }
                    else if (User.Toss.Equals(RPS.Scissors) && Randa.Toss.Equals(RPS.Paper))
                    {
                        Console.WriteLine("\n::RANDA ELIMINATED!::");
                        RandaElm = true;
                    }
                    else if (User.Toss == Randa.Toss)
                    {
                        Console.WriteLine($"\n::{User.Name} DRAWS WITH RANDA::");
                    }
                    else
                    {
                        Console.WriteLine("\n::YOU LOSE!!::");
                        User.Losses++;
                        return User;
                    }

                }

                //Once Rocky and Randa both lose, return a win
                if (RockyElm && RandaElm)
                {
                    Console.WriteLine("\n::YOU WIN!!::");
                    User.Wins++;
                    return User;
                }

            }
        }
    }
}
