using _8PuzzleGame.Solvers;
using System;

namespace _8PuzzleGame
{
    public class Startup
    {
        public static void Main()
        {
            // 1,2,5,3,4,0,6,7,8
            //var arr = new int[3, 3] { { 1, 2, 5 }, { 3, 4, 0 }, { 6, 7, 8 } };

            var arr = new int[3, 3] { { 8, 7, 6 }, { 5, 4, 0 }, { 3, 2, 1 } };

            //var arr = new int[3, 3] { { 8, 1, 2 }, { 3, 4, 5 }, { 6, 7, 0, } };

            var board = new Board(arr);
            board.Print(board);
            var startingState = new State(board, null, null, 0);
            
            
            var idaStar = new BfsSolver();
            var measurer1 = new PerformanceMeasurer();
            measurer1.StartMeasuring();
            idaStar.Solve(startingState);
            measurer1.StopMeasuring();
            measurer1.PrintResults();
            
            /*
            var aStar = new AStarSolver();
            var measurer2 = new PerformanceMeasurer();
            measurer2.StartMeasuring();
            aStar.Solve(startingState);
            measurer2.StopMeasuring();
            measurer2.PrintResults();*/
            
        }
    }
}
