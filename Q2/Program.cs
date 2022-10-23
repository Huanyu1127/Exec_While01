using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	//使用 while , 在畫面顯示所有可以整除 300 的整數，例如: 1, 2, 3, 4, 5, 6, 10, ...., 300
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = 1;
			while (number <= 300)
			{
				if (300 % number == 0)
				{
					Console.WriteLine(number);
				}
				number++;
			}
		}
	}
}
