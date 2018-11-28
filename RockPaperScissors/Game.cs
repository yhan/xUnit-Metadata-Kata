namespace RockPaperScissors
{
    using System.Collections.Generic;

    public class Game
    {
        private Winner _winner = Winner.Draw;

        private Dictionary<Winner, PlayerScore> playerScores = new Dictionary<Winner, PlayerScore>
        {
            [Winner.Player1] = new PlayerScore(),
            [Winner.Player2] = new PlayerScore(),
        };

        public Winner GetWinner()
        {
            return _winner;
        }

        public void PlayRound(string player1, string player2)
        {
            Winner winner = new Round().Play(player1, player2);



            if (playerScores.TryGetValue(winner, out PlayerScore playerScore))
            {
                int score = playerScore.Scoring();
                if (score == 2)
                {
                    _winner = winner;
                }
            }
        }
    }

    public class PlayerScore
    {
        private int _score;

        public int Scoring()
        {
            _score++;
            return _score;
        }
    }
}