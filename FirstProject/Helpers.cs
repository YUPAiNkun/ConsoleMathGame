using FirstProject.Models;
using System.ComponentModel;

namespace FirstProject
{
    internal class Helpers
    {
        static internal List<Game> games = new()
        {
            //new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            //new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
            //new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
            //new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
            //new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
            //new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
            //new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
            //new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
            //new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
        };
        static internal int maxNumber = 11; // maximum possible number in game
        static internal GameDifficulty difficultyGame = GameDifficulty.Easy;
        static internal int countGames = 5;
        internal static void PrintGames()
        {
            //var gamesToPrint = games.Where(x => x.Type == GameType.Division).OrderByDescending(x=>x.Score);

            Console.Clear();
            Console.WriteLine("Games history:");
            Console.WriteLine("-----------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} pts on {game.Difficulty} level in {game.Timer}" );
            }
            Console.WriteLine("-----------------------\n");
            Console.WriteLine("Press any key to return to menu");
            Console.ReadLine();
        }

        internal static void AddToHistory(int gameScore, GameType gameType, GameDifficulty difficulty, TimeSpan time)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType,
                Difficulty = difficulty,
                Timer = time
            });
        }

        internal static int[] GetDivisionNumbers()
        {
            Random random = new Random();
            int firstNumber = random.Next(1, maxNumber);
            int secondNumber = random.Next(1, maxNumber);

            int[] result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, maxNumber);
                secondNumber = random.Next(1, maxNumber);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer need to be integer. Try again");
                result = Console.ReadLine();
            }
            return result;
        }

        internal static string GetName()
        {
            Console.WriteLine("Please type your name");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name can't be empty");
                name = Console.ReadLine();
            }

            return name;
        }

        internal static void SelectDifficulty()
        {

            Console.Clear();
            Console.WriteLine(@"Select difficulty level:
          E - easy (maximum possible number 10)
          N - normal (maximum possible number 50)
          H - hard (maximum possible number 100");

            var levelDif = Console.ReadLine();
            switch (levelDif.Trim().ToLower())
            {
                case "e":
                    maxNumber = 11;
                    difficultyGame = GameDifficulty.Easy;
                    break;
                case "n":
                    maxNumber = 51;
                    difficultyGame = GameDifficulty.Normal;
                    break;
                case "h":
                    maxNumber = 101;
                    difficultyGame = GameDifficulty.Hard;
                    break;
            }
        }

        internal static void SelectNumberGame()
        {
            Console.Clear();
            Console.WriteLine(@"Select number of games
          D - default (5)
          C - custom");
            var numberGames = Console.ReadLine();

            switch (numberGames.Trim().ToLower())
            {
                case "d":
                    countGames = 5;
                    Console.WriteLine("You select default number of games");
                    break;
                case "c":
                    Console.WriteLine("Enter the desired number of games");
                    countGames = Int32.Parse(Console.ReadLine());
                    break;
            }
        }
    }
}
