namespace FirstProject
{
    internal class Menu
    {
        GameEngine engine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Hello {name}. It's {date}. This is math's game. That's great that you're working on improving yourself\n\n");
            Console.WriteLine("Press any key to show menu");
            Console.ReadLine();
            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play today? Choose from the options below:
            V - View score
            L - Select level difficulty
            С - Select number of questions
            A - Addition
            S - Substraction
            M - Multiplication
            D - Division
            Q - Quit the program");
                Console.WriteLine("------------------------------------");

                string gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "l":
                        Helpers.SelectDifficulty();
                        break;
                    case "c":
                        Helpers.SelectNumberGame();
                        break;
                    case "a":
                        engine.AdditionGame();
                        break;
                    case "s":
                        engine.SubtractionGame();
                        break;
                    case "m":
                        engine.MultiplicationGame();
                        break;
                    case "d":
                        engine.DivisionGame();
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        Environment.Exit(1);
                        break;
                }
            } while (isGameOn);
        }
    }
}
