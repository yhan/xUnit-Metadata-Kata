namespace RockPaperScissors
{
    using System.Collections.Generic;

    public class Round
    {
        private readonly Dictionary<Players, RoundResult> _rules = new Dictionary<Players, RoundResult>
        {
            [new Players(KindOfFigure.Rock, KindOfFigure.Scissors)] = RoundResult.Player1,
            [new Players(KindOfFigure.Rock, KindOfFigure.Paper)] = RoundResult.Player2,
            [new Players(KindOfFigure.Paper, KindOfFigure.Rock)] = RoundResult.Player1,
            [new Players(KindOfFigure.Paper, KindOfFigure.Scissors)] = RoundResult.Player2,
            [new Players(KindOfFigure.Scissors, KindOfFigure.Paper)] = RoundResult.Player1,
            [new Players(KindOfFigure.Scissors, KindOfFigure.Rock)] = RoundResult.Player2,
            [new Players(KindOfFigure.Scissors, KindOfFigure.Scissors)] = RoundResult.Draw,
            [new Players(KindOfFigure.Rock, KindOfFigure.Rock)] = RoundResult.Draw,
            [new Players(KindOfFigure.Paper, KindOfFigure.Paper)] = RoundResult.Draw
        };

        public RoundResult Play(KindOfFigure player1, KindOfFigure player2)
        {
            if (_rules.TryGetValue(new Players(player1, player2), out RoundResult result))
            {
                return result;
            }

            throw new InvalidMoveException();
        }
    }
}