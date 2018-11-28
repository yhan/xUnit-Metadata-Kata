namespace RockPaperScissors
{
    using System.Collections.Generic;

    public class Game
    {
        private readonly Dictionary<RoundResult, PlayerScore> _playerScores = new Dictionary<RoundResult, PlayerScore>
        {
            [RoundResult.Player1] = new PlayerScore(),
            [RoundResult.Player2] = new PlayerScore()
        };

        private RoundResult _roundResult = RoundResult.Draw;

        public RoundResult GetWinner()
        {
            return _roundResult;
        }

        public void PlayRound(KindOfFigure player1, KindOfFigure player2)
        {
            if (IsGameOver())
            {
                return;
            }

            RoundResult roundResult = new Round().Play(player1, player2);

            if (_playerScores.TryGetValue(roundResult, out PlayerScore playerScore))
            {
                if (HasWon(playerScore))
                {
                    _roundResult = roundResult;
                }
            }
        }

        private static bool HasWon(PlayerScore playerScore)
        {
            return playerScore.Scoring() == 2;
        }

        private bool IsGameOver()
        {
            return _roundResult != RoundResult.Draw;
        }
    }
}