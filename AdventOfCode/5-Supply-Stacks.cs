using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class _5_Supply_Stacks
    {
        private readonly string _puzzleInput;

        public _5_Supply_Stacks(string puzzleInput)
        {
            _puzzleInput = puzzleInput;
        }

        public string ProcessInput()
        {
            var result = string.Empty;
            var stacksString = _puzzleInput.Split("\r\n\r\n")[0];
            var moves = _puzzleInput.Split("\r\n\r\n")[1].Split('\n').ToList();
            var stacks = ParseStacks(stacksString);
            stacks = ProcessStacks(stacks, moves);
            foreach (var stack in stacks)
            {
                result += stack.Peek();
            }
            return result.Replace("[","").Replace("]","").Trim();
        }

        private List<Stack<string>> ParseStacks(string stacksString)
        {
            var result = new List<Stack<string>>();
            var b = stacksString.Split("\r\n").ToList();
            foreach (var row in b)
            {
                var stack = new Stack<string>();
                result.Add(stack);
            }
            var a = b[0].Replace("   ", "").Split(" ").ToList();
            //var a = new Stack<string>();
            //a.Push("[Z]");
            //a.Push("[N]");

            //var b = new Stack<string>();
            //b.Push("[M]");
            //b.Push("[C]");
            //b.Push("[D]");

            //var c = new Stack<string>();
            //c.Push("[P]");

            //result.Add(a);
            //result.Add(b);
            //result.Add(c);
            return result;
        }

        private List<Stack<string>> ProcessStacks(List<Stack<string>> stacks, List<string> moves)
        {
            foreach (var move in moves)
            {
                var moveList = move
                    .Replace("move","")
                    .Replace("from", "")
                    .Replace("to", "")
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => Convert.ToInt32(x))
                    .ToList();

                for (int i = 0; i < moveList[0]; i++)
                {
                    var a = stacks[moveList[1]-1].Pop();
                    stacks[moveList[2]-1].Push(a);
                }
            }
            return stacks;
        }

        public string ProcessInputPartTwo()
        {
            throw new NotImplementedException();
        }
    }
}
