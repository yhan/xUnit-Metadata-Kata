using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFluent;
using NUnit.Framework;

namespace RockPaperScissors.Test
{
    public class RoundShould
    {
        [Test]
        public void Return_1_rock_blunts_scissors_PASS_When_draw_Rock_Scissors()
        {
            int result = new Round().Play("Rock", "Scissors");
            Check.That(result).IsEqualTo(1);
        }

        [Test]
        public void Return_2_rock_blunts_scissors_PASS_When_draw_Scissors_Rock()
        {
            int result = new Round().Play("Scissors", "Rock");
            Check.That(result).IsEqualTo(2);
        }

        [Test]
        public void Return_1_scissors_cut_paper_PASS_When_draw_Scissors_Paper()
        {
            int result = new Round().Play("Scissors", "Paper");
            Check.That(result).IsEqualTo(1);
        }

        [Test]
        public void Return_2_scissors_cut_paper_PASS_When_draw_Paper_Scissors()
        {
            int result = new Round().Play("Paper", "Scissors");
            Check.That(result).IsEqualTo(2);
        }

        [Test]
        public void Return_1_paper_wraps_rock_PASS_When_draw_Paper_Rock()
        {
            int result = new Round().Play("Paper", "Rock");
            Check.That(result).IsEqualTo(1);
        }

        [Test]
        public void Return_2_paper_wraps_rock_PASS_When_draw_Rock_Paper()
        {
            int result = new Round().Play("Rock", "Paper");
            Check.That(result).IsEqualTo(2);
        }


        [Test]
        public void Return_0_round_is_a_draw_When_draw_Rock_Rock()
        {
            int result = new Round().Play("Rock", "Rock");
            Check.That(result).IsEqualTo(0);
        }

        [Test]
        public void Return_0_round_is_a_draw_When_draw_Scissors_Scissors()
        {
            int result = new Round().Play("Scissors", "Scissors");
            Check.That(result).IsEqualTo(0);
        }

        [Test]
        public void Return_0_round_is_a_draw_When_draw_Paper_Paper()
        {
            int result = new Round().Play("Paper", "Paper");
            Check.That(result).IsEqualTo(0);
        }

        [Test]
        public void Return_InvalidMoveException_When_invalid_inputs()
        {
            Check.ThatCode(() => new Round().Play("Blah", "Foo")).Throws<InvalidMoveException>();
        }
    }
}
