using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code_2024;

class TextFileReader
{
    public string[] ReadTextFile(string pathToFile)
    {
        // Read all text from the file
        string fileContent = System.IO.File.ReadAllText(pathToFile);

        // Trim any leading/trailing whitespace from the file content
        fileContent = fileContent.Trim();

        // Remove unwanted whitespace between words, replace multiple spaces with a single space
        fileContent = System.Text.RegularExpressions.Regex.Replace(fileContent, @"\s+", " ");

        // Split the text into numbers (or words) based on spaces and other delimiters
        string[] numbers = fileContent.Split(new[] { ' ', ',', '.', ';', ':', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        return numbers;
    }
}
