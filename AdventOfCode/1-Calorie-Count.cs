using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class _1_Calorie_Count : IAdventDay
    {
        private readonly List<string> _puzzleInput;

        public _1_Calorie_Count(string puzzleInput)
        {
            _puzzleInput = puzzleInput.Split('\n').ToList();
        }

        public int ProcessInput()
        {
            var result = new List<int>();
            var sum = 0;
            foreach (var elf in _puzzleInput)
            {
                if (string.IsNullOrWhiteSpace(elf))
                {
                    result.Add(sum);
                    sum = 0;
                    continue;
                }
                sum += Convert.ToInt32(elf);
            }

            return result.MaxBy(i => i);
        }

        public int ProcessInputPartTwo()
        {
            var result = new List<int>();
            var sum = 0;
            foreach (var elf in _puzzleInput)
            {
                if (string.IsNullOrWhiteSpace(elf))
                {
                    result.Add(sum);
                    sum = 0;
                    continue;
                }
                sum += Convert.ToInt32(elf);
            }

            return result.OrderByDescending(i => i).ToList().Take(3).Sum();
        }
    }
}
