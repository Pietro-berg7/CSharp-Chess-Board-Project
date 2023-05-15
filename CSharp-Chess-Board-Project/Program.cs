using CSharp_Chess_Board_Project.board;
using CSharp_Chess_Board_Project.chess;
using System;

namespace CSharp_Chess_Board_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            board.PlacePiece(new Tower(board, Color.Black), new Position(0, 0));
            board.PlacePiece(new Tower(board, Color.White), new Position(1, 3));
            board.PlacePiece(new King(board, Color.Black), new Position(2, 4));

            Screen.printBoard(board);

            Console.ReadLine();
        }
    }
}