namespace Labb2TicTacToe.Models
{
    public class Move
    {
        public char Symbol { get; set; }

        public int Cell { get; set; }

        public Move(char symbol, int cell)
        {
            Symbol = symbol;
            Cell = cell;
        }
    }
}