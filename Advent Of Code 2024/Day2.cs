using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code_2024
{
    class Day2
    {
		public static int RunDayTwo()
		{
			return CountHowManySafeReports(SeparateBySpace(ReadeFile(@"C:\Users\zimmej39\source\repos\Advent-Of-Code\InputFiles\Day2.txt")));
		}
		public static string[] ReadeFile(string textFile)
		{
			TextFileReaderDay2 reader = new TextFileReaderDay2();
			string[] myFileArrayByLine = reader.ReadTextFile(textFile);
			return myFileArrayByLine;
		}
		private static int[][] SeparateBySpace(string[] fileArrayByLine)
		{
			int[][] arrayOfLinesAndNumbers = new int[fileArrayByLine.Length][];
			int counter = 0;
			foreach (string line in fileArrayByLine)
			{
				int[] arrayOfSingleLine = line.Split(" ").Select(int.Parse).ToArray();
				arrayOfLinesAndNumbers[counter] = arrayOfSingleLine;
				counter++;
			}
			return arrayOfLinesAndNumbers;
        }

		private static int CountHowManySafeReports(int[][] reportsAndLevels)
		{
			int counterOfSafeReports = 0;
			bool currentReportSafeAsc = true;
			bool currentReportSafeDesc = true;
			
            for (int i = 0; i < reportsAndLevels.Length; i++) 
			{
				currentReportSafeAsc = true;
                currentReportSafeDesc = true;
                
				int copy = 0;
				for (int z = 0; z < reportsAndLevels[i].Length; z++)
				{
					copy = reportsAndLevels[i][z];
					reportsAndLevels[i][z] = -1;


                    for (int j = 0; j < reportsAndLevels[i].Length; j++)
					{
						

						if (j + 1 >= reportsAndLevels[i].Length)
						{
							continue;
						}
						else
						{
							if(reportsAndLevels[i][j] != -1)
							{
								continue;
                            }
							else if ((reportsAndLevels[i][j + 1] != -1) && (j+2 <= reportsAndLevels[i].Length))
							{
                                if ((reportsAndLevels[i][j] >= reportsAndLevels[i][j + 2])
                                    || (reportsAndLevels[i][j + 2] - reportsAndLevels[i][j] < 1)
                                    || (reportsAndLevels[i][j + 2] - reportsAndLevels[i][j] > 3))
                                {
                                    currentReportSafeAsc = false;
                                }
                                if ((reportsAndLevels[i][j] <= reportsAndLevels[i][j + 2]
                                || reportsAndLevels[i][j] - reportsAndLevels[i][j + 2] < 1
                                || reportsAndLevels[i][j] - reportsAndLevels[i][j + 2] > 3))
                                {
                                    currentReportSafeDesc = false;
                                }
                            }
							else
							{
                                if ((reportsAndLevels[i][j] >= reportsAndLevels[i][j + 1])
									|| (reportsAndLevels[i][j + 1] - reportsAndLevels[i][j] < 1)
									|| (reportsAndLevels[i][j + 1] - reportsAndLevels[i][j] > 3))
                                {
                                    currentReportSafeAsc = false;
                                }
                                if ((reportsAndLevels[i][j] <= reportsAndLevels[i][j + 1]
                                || reportsAndLevels[i][j] - reportsAndLevels[i][j + 1] < 1
                                || reportsAndLevels[i][j] - reportsAndLevels[i][j + 1] > 3))
                                {
                                    currentReportSafeDesc = false;
                                }
                            }
							
						}

					}
					reportsAndLevels[i][z] = copy;
                }
				if (currentReportSafeAsc || currentReportSafeDesc)
				{
					counterOfSafeReports ++;
				}
			}
			return counterOfSafeReports;
		}
    }
}
