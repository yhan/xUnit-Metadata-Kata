namespace RockPaperScissors.Test
{
    using System;

    using NFluent;

    using NUnit.Framework;

    public class GameShould
    {
        [Test]
        public void Return_1_player_1_wins_game_When_draw_Rock_Scissors_Rock_Scissors()
        {
            var listener = new SpyGameListener();
            var game = new Game();
            game.PlayRound(KindOfFigure.Rock, KindOfFigure.Scissors);
            game.PlayRound(KindOfFigure.Rock, KindOfFigure.Scissors);
            Check.That(game.GetWinner()).IsEqualTo(RoundResult.Player1);
        }

        [Test]
        public void Return_2_player_2_wins_game_When_draw_Rock_Paper_Rock_Paper()
        {
            var listener = new SpyGameListener();
            var game = new Game();
            game.PlayRound(KindOfFigure.Rock, KindOfFigure.Paper);
            game.PlayRound(KindOfFigure.Rock, KindOfFigure.Paper);
            Check.That(game.GetWinner()).IsEqualTo(RoundResult.Player2);
        }

        [Test]
        public void Return_0_drawers_not_counted_When_draw_Rock_Rock_Rock_Rock()
        {
            var listener = new SpyGameListener();
            var game = new Game();
            game.PlayRound(KindOfFigure.Rock, KindOfFigure.Rock);
            game.PlayRound(KindOfFigure.Rock, KindOfFigure.Rock);
            Check.That(game.GetWinner()).IsEqualTo(RoundResult.Draw);
        }

        [Test]
        public void Return_0_not_counted_When_invalid_moves()
        {
            var listener = new SpyGameListener();
            var game = new Game();
            try
            {
                game.PlayRound( (KindOfFigure)4, (KindOfFigure)5);
                game.PlayRound(KindOfFigure.Rock, KindOfFigure.Scissors);
            }
            catch (Exception e)
            {
            }

            Check.That(game.GetWinner()).IsEqualTo(RoundResult.Draw);
        }
    }
}