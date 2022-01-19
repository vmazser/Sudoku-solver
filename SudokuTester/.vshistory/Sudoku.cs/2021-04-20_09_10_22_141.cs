﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuTester
{
    class Sudoku
    {
        // Possible 
        //
        //public string SudokuNumbers { get; set; }

        public List<int> sudokuNumbers = new List<int>();
        public double gridCount { get; set; }


        public double GetNumer(int x, int y)
        {
            // Main Calculation for Getting the Serial number of a selected square.
            //
            // Serial number = (x - 1) * gridCount(for exaplme 4*4) + y
            
            gridCount = Math.Sqrt(sudokuNumbers.Count);
            double number = (x - 1) * gridCount + y;
            return number;
        }
    }
}
