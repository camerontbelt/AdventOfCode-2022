using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class _2_Rock_Paper_Scissors
    {
        private readonly List<string> _puzzleInput;

        public _2_Rock_Paper_Scissors(string puzzleInput)
        {
            _puzzleInput = puzzleInput.Split('\n').ToList();
        }
        //A,X Rock
        //B,Y Paper
        //C,Z Scissors

        public int ProcessInput()
        {
            var result = 0;
            foreach (var puzzleLine in _puzzleInput)
            {
                var playerOne = puzzleLine.Split(' ').First();
                switch (playerOne)
                {
                    case "A":
                        var playerTwo = puzzleLine.Split(' ')[1].Trim();
                        switch (playerTwo)
                        {
                            case "X":
                                result += 1 + 3;
                                break;
                            case "Y":
                                result += 2 + 6;
                                break;
                            case "Z":
                                result += 3 + 0;
                                break;
                        }
                        break;
                    case "B": 
                        playerTwo = puzzleLine.Split(' ')[1].Trim();
                        switch (playerTwo)
                        {
                            case "X":
                                result += 1 + 0;
                                break;
                            case "Y":
                                result += 2 + 3;
                                break;
                            case "Z":
                                result += 3 + 6;
                                break;
                        }
                        break;
                    case "C":
                        playerTwo = puzzleLine.Split(' ')[1].Trim();
                        switch (playerTwo)
                        {
                            case "X":
                                result += 1 + 6;
                                break;
                            case "Y":
                                result += 2 + 0;
                                break;
                            case "Z":
                                result += 3 + 3;
                                break;
                        }
                        break;
                }
            }
            return result;
        }

        public int ProcessInputPartTwo()
        {
            var result = 0;
            foreach (var puzzleLine in _puzzleInput)
            {
                var playerOne = puzzleLine.Split(' ').First();
                switch (playerOne)
                {
                    case "A"://rock
                        var playerTwo = puzzleLine.Split(' ')[1].Trim();
                        switch (playerTwo)
                        {
                            case "X"://lose
                                result += 3 + 0;
                                break;
                            case "Y"://draw
                                result += 1 + 3;
                                break;
                            case "Z"://win
                                result += 2 + 6;
                                break;
                        }
                        break;
                    case "B"://paper
                        playerTwo = puzzleLine.Split(' ')[1].Trim();
                        switch (playerTwo)
                        {
                            case "X"://lose
                                result += 1 + 0;
                                break;
                            case "Y"://draw
                                result += 2 + 3;
                                break;
                            case "Z"://win
                                result += 3 + 6;
                                break;
                        }
                        break;
                    case "C"://scissors
                        playerTwo = puzzleLine.Split(' ')[1].Trim();
                        switch (playerTwo)
                        {
                            case "X":
                                result += 2 + 0;
                                break;
                            case "Y":
                                result += 3 + 3;
                                break;
                            case "Z":
                                result += 1 + 6;
                                break;
                        }
                        break;
                }
            }
            return result;
        }
    }
}
