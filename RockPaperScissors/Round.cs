namespace RockPaperScissors
{
    using System.Collections.Generic;

    struct PlayComibination
    {
        private readonly string _player2;

        public string Player1 { get; }

        public PlayComibination(string player1, string player2)
        {
            _player2 = player2;
            Player1 = player1;
        }
    }

    public class Round
    {
        private Dictionary<PlayComibination, Winner> _rules = new Dictionary<PlayComibination, Winner>()
                  {
                      [new PlayComibination(Rock, Scissors)] = Winner.Player1,
                      [new PlayComibination(Rock, Paper)] = Winner.Player2,
                      [new PlayComibination(Paper, Rock)] = Winner.Player1,
                      [new PlayComibination(Paper, Scissors)] = Winner.Player2,
                      [new PlayComibination(Scissors, Paper)] = Winner.Player1,
                      [new PlayComibination(Scissors, Rock)] = Winner.Player2,
                      [new PlayComibination(Scissors, Scissors)] = Winner.Draw,
                      [new PlayComibination(Rock, Rock)] = Winner.Draw,
                      [new PlayComibination(Paper, Paper)] = Winner.Draw,
                  };

        private const string Rock = "Rock";
        private const string Scissors = "Scissors";
        private const string Paper = "Paper";

        public Winner Play(string player1, string player2)
        {
            if (_rules.TryGetValue(new PlayComibination(player1, player2), out var result))
            {
                return result;
            }

            throw new InvalidMoveException();
        }
    }

    public enum Winner
    {
        Draw = 0,
        Player1,
        Player2
    }
}