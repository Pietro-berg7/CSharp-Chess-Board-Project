using CSharp_Chess_Board_Project.Board;
using System;

namespace CSharp_Chess_Board_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Position P;

            P = new Position(3, 4);

            Console.WriteLine("Position: " + P);
            Console.ReadLine();
        }
    }
}