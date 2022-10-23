using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	//1+ 2 + 3 + 4 + .... + N <105請問 N 是多少?
	internal class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;
			int first = 1;
			while (sum < 105)
			{
				sum += first;
				first++;
			}
			Console.WriteLine(first - 2); //N是13 N是14剛好=105

			//int sum = 0;
			//int first = 0;
			//while (sum < 105)
			//{
			//	first++;
			//	sum += first;
			//}
			//Console.WriteLine(first - 1); //N是13
		}
	}
}
