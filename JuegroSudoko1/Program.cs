using System;
using System.Media;
using System.Threading;
using JuegroSudoko1;
using Spectre.Console;

namespace SudokuGame
{
    class Program
    {
        static void Main(string[] args)
        {
            new Juego().Iniciar();
        }
    }
}