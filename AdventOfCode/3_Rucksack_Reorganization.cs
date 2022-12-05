using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class _3_Rucksack_Reorganization : IAdventDay
    {
        private readonly List<string> _puzzleInput;

        public _3_Rucksack_Reorganization(string puzzleInput)
        {
            _puzzleInput = puzzleInput.Split('\n').ToList();
        }

        public int ProcessInput()
        {
            var result = new List<int>();
            foreach (var ruckSack in _puzzleInput)
            {
                var items = GetItems(ruckSack);
                var itemType = GetItemType(items);
                result.Add(MapLetterToNumber(itemType));
            }

            return result.Sum();
        }

        private char GetItemType(List<string> items)
        {
            foreach (var character in items[0])
            {
                if (items[1].Contains(character)) return character;
            }
            return ' ';
        }

        private List<string> GetItems(string ruckSack)
        {
            var result = new List<string>
            {
                ruckSack.Substring(0, ruckSack.Length / 2),
                ruckSack.Substring(ruckSack.Length / 2).Trim()
            };
            return result;
        }

        public int MapLetterToNumber(char character)
        {
            if(char.IsUpper(character)) return character - 38;
            else if (char.IsLower(character)) return character - 96;
            return 0;
        }

        public int ProcessInputPartTwo()
        {
            var result = new List<int>();

            for (int i = 0; i < _puzzleInput.Count; i+=3)
            {
                var itemType = GetItemTypePartTwo(_puzzleInput[i].Trim(), _puzzleInput[i + 1].Trim(), _puzzleInput[i + 2].Trim());
                result.Add(MapLetterToNumber(itemType));
            }
            return result.Sum();
        }

        private char GetItemTypePartTwo(string itemOne, string itemTwo, string itemThree)
        {
            foreach (var character in itemOne)
            {
                if (itemTwo.Contains(character) && itemThree.Contains(character)) 
                    return character;
            }
            return ' ';
        }
    }
}
