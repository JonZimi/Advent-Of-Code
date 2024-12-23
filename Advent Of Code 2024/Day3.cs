using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Advent_Of_Code_2024
{
    class Day3
    {
        private string pattern = @"mul\(([1-9][0-9]{0,2}),([1-9][0-9]{0,2})\)";
        private string text;
        private int total;

        public int RunDayThree()
        {
            text = ReadTextFile();
            CalculateMull();
            return total;
        }

        public string ReadTextFile()
        {
            string fileContent = System.IO.File.ReadAllText(@"C:\Users\zimmej39\source\repos\Advent-Of-Code\InputFiles\Day3.txt");
            return fileContent;
        }

        public void CalculateMull() 
        {
            MatchCollection mulls = Regex.Matches(text, pattern);
            foreach (Match mull in mulls)
            {
                int firstNumber = Int32.Parse(mull.Groups[1].Value);
                int secondNumber = Int32.Parse(mull.Groups[2].Value);
                total += firstNumber * secondNumber;
            }
        }
    }
}