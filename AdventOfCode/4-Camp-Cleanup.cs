using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class _4_Camp_Cleanup : IAdventDay
    {
        private readonly List<string> _puzzleInput;

        public _4_Camp_Cleanup(string puzzleInput)
        {
            _puzzleInput = puzzleInput.Split('\n').ToList();
        }

        public int ProcessInput()
        {
            var result = 0;
            foreach (var input in _puzzleInput)
            {
                var a = input.Split(',')[0];
                var b = input.Split(',')[1];

                var a1 = Convert.ToInt32(a.Split("-")[0]);
                var a2 = Convert.ToInt32(a.Split("-")[1]);

                var b1 = Convert.ToInt32(b.Split("-")[0]);
                var b2 = Convert.ToInt32(b.Split("-")[1]);

                if (a1 <= b1 && a2 >= b2) ++result;
                else if (b1 <= a1 && b2 >= a2) ++result;
            }

            return result;
        }

        public int ProcessInputPartTwo()
        {
            var result = 0;
            foreach (var input in _puzzleInput)
            {
                var a = input.Split(',')[0];
                var b = input.Split(',')[1];

                var a1 = Convert.ToInt32(a.Split("-")[0]);
                var a2 = Convert.ToInt32(a.Split("-")[1]);

                var b1 = Convert.ToInt32(b.Split("-")[0]);
                var b2 = Convert.ToInt32(b.Split("-")[1]);

                if (a1 <= b1 && a2 >= b2) 
                    ++result;
                else if (b1 <= a1 && b2 >= a2) 
                    ++result;
                else if (a2 >= b1 && a1 <= b2) 
                    ++result;
            }

            return result;
        }
    }
}
