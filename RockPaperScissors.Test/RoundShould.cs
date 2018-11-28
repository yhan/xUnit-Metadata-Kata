namespace RockPaperScissors.Test
{
    using NFluent;

    using NUnit.Framework;

    public class RoundShould
    {
        [Test]
        public void Return_1_rock_blunts_scissors_PASS_When_draw_Rock_Scissors()
        {
            var winner = new Round().Play(KindOfFigure.Rock, KindOfFigure.Scissors);
            Check.That(winner).IsEqualTo(RoundResult.Player1);
        }

        [Test]
        public void Return_2_rock_blunts_scissors_PASS_When_draw_Scissors_Rock()
        {
            var winner = new Round().Play(KindOfFigure.Scissors, KindOfFigure.Rock);
            Check.That(winner).IsEqualTo(RoundResult.Player2);
        }

        [Test]
        public void Return_1_scissors_cut_paper_PASS_When_draw_Scissors_Paper()
        {
            var winner = new Round().Play(KindOfFigure.Scissors, KindOfFigure.Paper);
            Check.That(winner).IsEqualTo(RoundResult.Player1);
        }

        [Test]
        public void Return_2_scissors_cut_paper_PASS_When_draw_Paper_Scissors()
        {
            var winner = new Round().Play(KindOfFigure.Paper, KindOfFigure.Scissors);
            Check.That(winner).IsEqualTo(RoundResult.Player2);
        }

        [Test]
        public void Return_1_paper_wraps_rock_PASS_When_draw_Paper_Rock()
        {
            var winner = new Round().Play(KindOfFigure.Paper, KindOfFigure.Rock);
            Check.That(winner).IsEqualTo(RoundResult.Player1);
        }

        [Test]
        public void Return_2_paper_wraps_rock_PASS_When_draw_Rock_Paper()
        {
            var winner = new Round().Play(KindOfFigure.Rock, KindOfFigure.Paper);
            Check.That(winner).IsEqualTo(RoundResult.Player2);
        }

        [Test]
        public void Return_0_round_is_a_draw_When_draw_Rock_Rock()
        {
            var winner = new Round().Play(KindOfFigure.Rock, KindOfFigure.Rock);
            Check.That(winner).IsEqualTo(RoundResult.Draw);
        }

        [Test]
        public void Return_0_round_is_a_draw_When_draw_Scissors_Scissors()
        {
            var winner = new Round().Play(KindOfFigure.Scissors, KindOfFigure.Scissors);
            Check.That(winner).IsEqualTo(RoundResult.Draw);
        }

        [Test]
        public void Return_0_round_is_a_draw_When_draw_Paper_Paper()
        {
            RoundResult winner = new Round().Play(KindOfFigure.Paper, KindOfFigure.Paper);
            Check.That(winner).IsEqualTo(RoundResult.Draw);
        }

        [Test]
        public void Return_InvalidMoveException_When_invalid_inputs()
        {
            Check.ThatCode(() => new Round().Play((KindOfFigure)4, (KindOfFigure)5)).Throws<InvalidMoveException>();
        }
    }
}