﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuTester
{
    class Sudoku
    {
        // Possible string, in, char
        //
        //public string SudokuNumbers { get; set; }
        //public List<int> SudokuNumbers = new List<int>();
        //public List<string> SudokuNumbers = new List<string>();

        public List<char> sudokuNumbers = new List<char>();
        public int gridCount { get; set; }


        public int GetNumer(int x, int y)
        {
            // Main Calculation for Getting the Serial number of a selected square.
            //
            // Serial number = (x - 1) * gridCount(for exaplme 4*4) + y
            //
            //
            gridCount = Math.Sqrt(sudokuNumbers.Count);


            int s = gridCount;
            int number = (x - 1) * s + y;
            return number;
        }
    }
}
