namespace RockPaperScissors
{
    public struct Players
    {
        private readonly KindOfFigure _player2;

        private readonly KindOfFigure _player1;

        public Players(KindOfFigure player1, KindOfFigure player2)
        {
            _player2 = player2;
            _player1 = player1;
        }
    }
}