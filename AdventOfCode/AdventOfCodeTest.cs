using NUnit.Framework;

namespace AdventOfCode
{
    [TestFixture]
    public class AdventOfCodeTest
    {

        [Test]
        public void _1_Calorie_Count_test()
        {
            var puzzleInput = "1000\r\n2000\r\n3000\r\n\r\n4000\r\n\r\n5000\r\n6000\r\n\r\n7000\r\n8000\r\n9000\r\n\r\n10000\r\n\r\n";
            var rps = new _1_Calorie_Count(puzzleInput);
            var answer = rps.ProcessInput();
            Assert.AreEqual(24000, answer);
        }

        [Test]
        public void _1_Calorie_Count_part_2_Test()
        {
            var puzzleInput = "1000\r\n2000\r\n3000\r\n\r\n4000\r\n\r\n5000\r\n6000\r\n\r\n7000\r\n8000\r\n9000\r\n\r\n10000\r\n\r\n";
            var rps = new _1_Calorie_Count(puzzleInput);
            var answer = rps.ProcessInputPartTwo();
            Assert.AreEqual(45000, answer);
        }

        [Test]
        public void _2_Rock_Paper_Scissors_Test()
        {
            var puzzleInput = "A Y\r\nB X\r\nC Z";
            var rps = new _2_Rock_Paper_Scissors(puzzleInput);
            var answer = rps.ProcessInput();
            Assert.AreEqual(15, answer);
        }

        [Test]
        public void _2_Rock_Paper_Scissors_part_2_Test()
        {
            var puzzleInput = "A Y\r\nB X\r\nC Z";
            var rps = new _2_Rock_Paper_Scissors(puzzleInput);
            var answer = rps.ProcessInputPartTwo();
            Assert.AreEqual(12, answer);
        }

        [Test]
        public void _3_Rucksack_Reorganization_Test()
        {
            var puzzleInput = "vJrwpWtwJgWrhcsFMMfFFhFp\r\njqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL\r\nPmmdzqPrVvPwwTWBwg\r\nwMqvLMZHhHMvwLHjbvcjnnSBnvTQFn\r\nttgJtRGJQctTZtZT\r\nCrZsJsPPZsGzwwsLwLmpwMDw";
            var rps = new _3_Rucksack_Reorganization(puzzleInput);
            var answer = rps.ProcessInput();
            Assert.AreEqual(157, answer);
        }

        [Test]
        public void _3_Rucksack_Reorganization_Part_2_Test()
        {
            var puzzleInput = "vJrwpWtwJgWrhcsFMMfFFhFp\r\njqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL\r\nPmmdzqPrVvPwwTWBwg\r\nwMqvLMZHhHMvwLHjbvcjnnSBnvTQFn\r\nttgJtRGJQctTZtZT\r\nCrZsJsPPZsGzwwsLwLmpwMDw";
            var rps = new _3_Rucksack_Reorganization(puzzleInput);
            var answer = rps.ProcessInputPartTwo();
            Assert.AreEqual(70, answer);
        }

        [Test]
        public void _4_Test()
        {
            var puzzleInput = "2-4,6-8\r\n2-3,4-5\r\n5-7,7-9\r\n2-8,3-7\r\n6-6,4-6\r\n2-6,4-8";
            var rps = new _4_Camp_Cleanup(puzzleInput);
            var answer = rps.ProcessInput();
            Assert.AreEqual(2, answer);
        }

        [Test]
        public void _4_Part_2_Test()
        {
            var puzzleInput = "2-4,6-8\r\n2-3,4-5\r\n7-9,5-7\r\n2-8,3-7\r\n6-6,4-6\r\n2-6,4-8";
            var rps = new _4_Camp_Cleanup(puzzleInput);
            var answer = rps.ProcessInputPartTwo();
            Assert.AreEqual(4, answer);
        }

        [Test]
        public void _5_Test()
        {
            var puzzleInput = "    [D]    \r\n[N] [C]    \r\n[Z] [M] [P]\r\n 1   2   3 \r\n\r\nmove 1 from 2 to 1\r\nmove 3 from 1 to 3\r\nmove 2 from 2 to 1\r\nmove 1 from 1 to 2";
            var rps = new _5_Supply_Stacks(puzzleInput);
            var answer = rps.ProcessInput();
            Assert.Contains("CMZ",new[] { answer });
        }

        [Test]
        public void _5_Part_2_Test()
        {
            var puzzleInput = "    [D]    \r\n[N] [C]    \r\n[Z] [M] [P]\r\n 1   2   3 \r\n\r\nmove 1 from 2 to 1\r\nmove 3 from 1 to 3\r\nmove 2 from 2 to 1\r\nmove 1 from 1 to 2";
            var rps = new _5_Supply_Stacks(puzzleInput);
            var answer = rps.ProcessInputPartTwo();
            Assert.Contains("MCD", new[] { answer });
        }
    }
}
