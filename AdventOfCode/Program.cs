// See https://aka.ms/new-console-template for more information

using AdventOfCode;

var puzzleInput = File.ReadAllText(@"c:\temp\day-5-input.txt");
var advent = new _5_Supply_Stacks(puzzleInput);
var answer = advent.ProcessInput();
Console.WriteLine(answer);