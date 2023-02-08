namespace FirstProject.Models;

internal class Game
{
    internal int Score { get; set; }
    internal DateTime Date { get; set; }
    internal GameType Type { get; set; }
    internal GameDifficulty Difficulty { get; set; }
    internal TimeSpan Timer { get; set; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}

internal enum GameDifficulty
{
    Easy,
    Normal,
    Hard
}

