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
            game.PlayRound("Rock", "Scissors");
            game.PlayRound("Rock", "Scissors");
            Check.That(game.GetWinner()).IsEqualTo(Winner.Player1);
        }

        [Test]
        public void Return_2_player_2_wins_game_When_draw_Rock_Paper_Rock_Paper()
        {
            var listener = new SpyGameListener();
            var game = new Game();
            game.PlayRound("Rock", "Paper");
            game.PlayRound("Rock", "Paper");
            Check.That(game.GetWinner()).IsEqualTo(Winner.Player2);
        }

        [Test]
        public void Return_0_drawers_not_counted_When_draw_Rock_Rock_Rock_Rock()
        {
            var listener = new SpyGameListener();
            var game = new Game();
            game.PlayRound("Rock", "Rock");
            game.PlayRound("Rock", "Rock");
            Check.That(game.GetWinner()).IsEqualTo(Winner.Draw);
        }

        [Test]
        public void Return_0_not_counted_When_invalid_moves()
        {
            var listener = new SpyGameListener();
            var game = new Game();
            try
            {
                game.PlayRound("Blah", "Foo");
                game.PlayRound("Rock", "Scissors");
            }
            catch (Exception e)
            {
            }

            Check.That(game.GetWinner()).IsEqualTo(Winner.Draw);
        }
    }
}