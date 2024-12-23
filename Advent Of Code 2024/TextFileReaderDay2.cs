using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code_2024
{
	class TextFileReaderDay2
	{
		public string[] ReadTextFile(string pathToFile)
		{
			string fileContent = System.IO.File.ReadAllText(pathToFile);
			string[] lines = fileContent.Split(Environment.NewLine);
			return lines;
		}
	}
}
