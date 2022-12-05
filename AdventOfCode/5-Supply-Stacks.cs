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
            return result.Trim();
        }

        private List<Stack<string>> ParseStacks(string stacksString)
        {
            var result = new List<Stack<string>>();
            var lines = stacksString.Split("\r\n").ToList();
            var lastLine = lines.Last();
            
            var count = Convert.ToInt32(stacksString.Split("\r\n").ToList().Last().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList().Last());
            for (var i = 1; i <= count; i++)
            {
                var stack = new Stack<string>();
                var index = lastLine.IndexOf(i.ToString(),0);
                for (int j = 0; j < count; j++)
                {
                    var item = lines[j][index];
                    if (char.IsAsciiLetter(item)) stack.Push(item.ToString());
                }
                result.Add(Reverse(stack));
            }
            return result;
        }

        private static Stack<string> Reverse(Stack<string> input)
        {
            Stack<string> temp = new Stack<string>();

            while (input.Count != 0)
                temp.Push(input.Pop());

            return temp;
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

        private List<Stack<string>> ProcessStacksPartTwo(List<Stack<string>> stacks, List<string> moves)
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

                var tempStack = new Stack<string>();
                for (int i = 0; i < moveList[0]; i++)
                {
                    var a = stacks[moveList[1]-1].Pop();
                    tempStack.Push(a);
                }

                while(tempStack.Count > 0)
                {
                    var a = tempStack.Pop();
                    stacks[moveList[2] - 1].Push(a);
                }
            }
            return stacks;
        }

        public string ProcessInputPartTwo()
        {
            var result = string.Empty;
            var stacksString = _puzzleInput.Split("\r\n\r\n")[0];
            var moves = _puzzleInput.Split("\r\n\r\n")[1].Split('\n').ToList();
            var stacks = ParseStacks(stacksString);
            stacks = ProcessStacksPartTwo(stacks, moves);
            foreach (var stack in stacks)
            {
                result += stack.Peek();
            }
            return result.Trim();
        }
    }
}
