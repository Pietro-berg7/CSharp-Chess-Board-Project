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
            ChessPosition pos = new ChessPosition('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosition());

            Console.ReadLine();
        }
    }
}