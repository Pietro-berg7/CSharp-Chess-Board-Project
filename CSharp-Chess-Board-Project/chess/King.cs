using CSharp_Chess_Board_Project.board;

namespace CSharp_Chess_Board_Project.chess
{
    internal class King: Piece
    {
        public King(Board board, Color color) : base(board, color)
        {
        }

        public override string ToString()
        {
            return "K";
        }
    }
}
