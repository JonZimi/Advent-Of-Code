using System.Collections.Generic;

namespace Advent_Of_Code_2024;

internal class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        myMenu.SayHello();
        switch (myMenu.AskUserWhatCodingChallangeHeWantsToSolve())
        {
            case 1:

                Day1.SeparateTwoLists();

                // Step 2: Calculate the total difference
                long totalDifference = Day1.CalculateTotalDifference();

                long secondStar = Day1.CalculateHowOftenRigthNumbersAppearInLeftList();

                // Step 3: Print the result
                Console.WriteLine($"The total difference is: {totalDifference}");
                Console.WriteLine($"Second star:{secondStar}");
                break;
            case 2:
                Console.WriteLine($"The answer for the first star is: {Day2.RunDayTwo()}");
                break;
            case 3:
                Day3 day3 = new Day3();
                Console.WriteLine($"The answer for the first star is{day3.RunDayThree()}");
                break;
        }
        
    }
}
