using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code_2024;

internal class Menu
{
    public void SayHello()
    {
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("-------------------------------------Welcome to Jons advent of code!-----------------------------------------");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
    }
    public int AskUserWhatCodingChallangeHeWantsToSolve()
    {
        Console.WriteLine("What day do you want to do?\n");
        Console.WriteLine("""
                        ------Options------
                        1. Day 1
                        2. Day2 (Second star)
                        3. Day3 (First star)
                        -------------------
                       """);
        Console.WriteLine("Press the number to start:");
        string strInput = Console.ReadLine();
        int input = Int32.Parse(strInput);
        return input;
    }
}
