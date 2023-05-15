using CSharp_Chess_Board_Project.board;
using System;

namespace CSharp_Chess_Board_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            Screen.printBoard(board);

            Console.ReadLine();
        }
    }
}