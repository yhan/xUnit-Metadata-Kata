using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFluent;
using NUnit.Framework;

namespace RockPaperScissors.Test
{
    public class GameShould
    {
        [Test]
        public void Return_1_player_1_wins_game_When_draw_Rock_Scissors_Rock_Scissors()
        {
            SpyGameListener listener = new SpyGameListener();
            Game game = new Game(listener);
            game.PlayRound("Rock", "Scissors");
            game.PlayRound("Rock", "Scissors");
            Check.That(listener.Winner).IsEqualTo(1);
        }

        [Test]
        public void Return_2_player_2_wins_game_When_draw_Rock_Paper_Rock_Paper()
        {
            SpyGameListener listener = new SpyGameListener();
            var game = new Game(listener);
            game.PlayRound("Rock", "Paper");
            game.PlayRound("Rock", "Paper");
            Check.That(listener.Winner).IsEqualTo(2);
        }

        [Test]
        public void Return_0_drawers_not_counted_When_draw_Rock_Rock_Rock_Rock()
        {
            SpyGameListener listener = new SpyGameListener();
            var game = new Game(listener);
            game.PlayRound("Rock", "Rock");
            game.PlayRound("Rock", "Rock");
            Check.That(listener.Winner).IsEqualTo(0);
        }

        [Test]
        public void Return_0_not_counted_When_invalid_moves()
        {
            var listener = new SpyGameListener();
            var game = new Game(listener);
            try
            {
                game.PlayRound("Blah", "Foo");
                game.PlayRound("Rock", "Scissors");
            }
            catch (Exception e)
            {

            }
            Check.That(listener.Winner).IsEqualTo(0);
        }
    }
}
