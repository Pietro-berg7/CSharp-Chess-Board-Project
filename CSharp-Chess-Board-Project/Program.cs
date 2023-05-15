using CSharp_Chess_Board_Project.board;
using CSharp_Chess_Board_Project.board.Exceptions;
using CSharp_Chess_Board_Project.chess;
using System;

namespace CSharp_Chess_Board_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board board = new Board(8, 8);

                board.PlacePiece(new Tower(board, Color.Black), new Position(0, 0));
                board.PlacePiece(new Tower(board, Color.White), new Position(1, 3));
                board.PlacePiece(new King(board, Color.Black), new Position(0, 2));

                Screen.printBoard(board);
            }
            catch(BoardException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}