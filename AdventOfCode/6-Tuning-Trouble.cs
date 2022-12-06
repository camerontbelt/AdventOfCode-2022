using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class _6_Tuning_Trouble : IAdventDay
    {
        private string _puzzleInput { get; set; }

        public _6_Tuning_Trouble(string puzzleInput)
        {
            _puzzleInput = puzzleInput;
        }

        public int ProcessInput()
        {
            var result = 0;
            for (int i = 0; i < _puzzleInput.Length; i++)
            {
                var a = _puzzleInput.Substring(i, 4);
                var b = a.Distinct().Count();
                if (b != 4) continue;
                result = i + 4;
                return result;
            }
            return result;
        }

        public int ProcessInputPartTwo()
        {
            var result = 0;
            for (int i = 0; i < _puzzleInput.Length; i++)
            {
                var a = _puzzleInput.Substring(i, 14);
                var b = a.Distinct().Count();
                if (b != 14) continue;
                result = i + 14;
                return result;
            }
            return result;
        }
    }
}
