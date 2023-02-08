using FirstProject.Models;

namespace FirstProject
{
    internal class GameEngine
    {
        internal void DivisionGame()
        {
            Console.Clear();

            var score = 0;
            DateTime countdown = DateTime.Now;//fixes the start time of the game
            for (int i = 0; i < Helpers.countGames; i++)
            {
                Console.Clear();
                var divisionNumbers = Helpers.GetDivisionNumbers();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber}/{secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key");
                    Console.ReadLine();
                }
            }
            DateTime endTime = DateTime.Now;//fixes the end of the game
            Helpers.AddToHistory(score, GameType.Division, Helpers.difficultyGame, (endTime-countdown));
            Console.WriteLine($"Your final score: {score}");
            Console.WriteLine("Press any key to go back to menu");
            Console.ReadLine();
        }

        internal void MultiplicationGame()
        {
            Console.Clear();

            Random random = new Random();
            int score = 0;
            DateTime countdown = DateTime.Now;//fixes the start time of the game
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < Helpers.countGames; i++)
            {
                Console.Clear();
                firstNumber = random.Next(1, Helpers.maxNumber);
                secondNumber = random.Next(1, Helpers.maxNumber);

                Console.WriteLine($"{firstNumber} * {secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key");
                    Console.ReadLine();
                }
            }
            DateTime endTime = DateTime.Now;//fixes the end of the game
            Helpers.AddToHistory(score, GameType.Division, Helpers.difficultyGame, (endTime - countdown));
            Console.WriteLine($"Your final score: {score}");
            Console.WriteLine("Press any key to go back to menu");
            Console.ReadLine();
        }

        internal void SubtractionGame()
        {
            Console.Clear();

            Random random = new Random();
            int score = 0;
            DateTime countdown = DateTime.Now;//fixes the start time of the game
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < Helpers.countGames; i++)
            {
                Console.Clear();
                firstNumber = random.Next(1, Helpers.maxNumber);
                secondNumber = random.Next(1, Helpers.maxNumber);

                Console.WriteLine($"{firstNumber} - {secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key");
                    Console.ReadLine();
                }
            }
            DateTime endTime = DateTime.Now;//fixes the end of the game
            Helpers.AddToHistory(score, GameType.Division, Helpers.difficultyGame, (endTime - countdown));
            Console.WriteLine($"Your final score: {score}");
            Console.WriteLine("Press any key to go back to menu");
            Console.ReadLine();
        }

        internal void AdditionGame()
        {
            Console.Clear();

            Random random = new Random();
            int score = 0;
            DateTime countdown = DateTime.Now;//fixes the start time of the game
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < Helpers.countGames; i++)
            {
                Console.Clear();
                firstNumber = random.Next(1, Helpers.maxNumber);
                secondNumber = random.Next(1, Helpers.maxNumber);

                Console.WriteLine($"{firstNumber} + {secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key");
                    Console.ReadLine();
                }
            }
            DateTime endTime = DateTime.Now;//fixes the end of the game
            Helpers.AddToHistory(score, GameType.Division, Helpers.difficultyGame, (endTime - countdown));
            Console.WriteLine($"Your final score: {score}");
            Console.WriteLine("Press any key to go back to menu");
            Console.ReadLine();
        }
    }
}
