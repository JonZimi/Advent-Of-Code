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

        }
        
    }
}
