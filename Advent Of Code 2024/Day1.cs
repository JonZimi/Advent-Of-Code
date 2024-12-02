using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code_2024
{
    internal class Day1
    {
        private static List<long> listOne = new List<long>();
        private static List<long> listTwo = new List<long>();
        public static string[] ReadeFile()
        {
            TextFileReader reader = new TextFileReader();
            string[] myFileArray = reader.ReadTextFile(@"C:\Users\zimmej39\source\repos\Advent Of Code 2024\InputFiles\Day1.txt");
            return myFileArray;
        }
        public static long[] ConvertFromStringToLong()
        {
            int counter = 0;
            string[] myFileStringArray = ReadeFile();
            long[] longFileArray =  new long[myFileStringArray.Length] ;
            foreach (string str in myFileStringArray) 
            {
                long longValue = long.Parse(str);
                longFileArray[counter] = longValue;
                counter++;
            }
            return longFileArray;
        }
        public static void SeparateTwoLists()
        {
            bool listOneBool = true;
            List<long> singleLongList = ConvertFromStringToLong().ToList();
            foreach (long myLong in singleLongList)
            {   
                if(listOneBool)
                {
                    listOne.Add(myLong);
                    listOneBool = false;
                }
                else
                {
                   listTwo.Add(myLong);
                    listOneBool= true;
                }
            }  
        }
        public static long CalculateTotalDifference()
        {
            long TotalDifference = 0;
            listOne = listOne.OrderBy(x => x).ToList();
            listTwo = listTwo.OrderBy(x => x).ToList();

            for (int i = 0; i < listOne.Count; i++)
            {
                if (listOne[i] > listTwo[i])
                {
                    long thisDifference = listOne[i] - listTwo[i];
                    TotalDifference += thisDifference;
                }
                else if (listOne[i] < listTwo[i])
                {
                    long thisDifference = listTwo[i] - listOne[i];
                    TotalDifference += thisDifference;
                }
                else
                {
                    continue;
                }
            }
            return TotalDifference;
        }

        public static long CalculateHowOftenRigthNumbersAppearInLeftList()
        {
            long totalCount = 0;
            foreach(long number in listOne)
            {
                long count = listTwo.Where(x => x == number).Count();
                totalCount += number * count;
            }
            return totalCount;
        }
    }
}
