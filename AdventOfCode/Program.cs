// See https://aka.ms/new-console-template for more information

using AdventOfCode;

var puzzleInput = File.ReadAllText(@"c:\temp\day-6-input.txt");
var advent = new _6_Tuning_Trouble(puzzleInput);
var answer = advent.ProcessInputPartTwo();
Console.WriteLine(answer);