using System;
using System.Collections.Generic;
using System.Linq;
using Rectangle.Impl;

namespace Rectangle.Console
{
	class Program
	{
		/// <summary>
		/// Use this method for local debugging only. The implementation should remain in Rectangle.Impl project.
		/// See TODO.txt file for task details.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			int[] number = RandomNumber(10);
			List<Point> listPoint = new List<Point>();
			
			for (int i = 0, j = number.Length-1; i < number.Length; i++, j--)
			{
				listPoint.Add(new Point(number[i],number[j]));
			}
			Service.FindRectangle(listPoint);
			System.Console.ReadKey();
		}

		/// <summary>
		/// Random number generator
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		private static int[] RandomNumber(int i)
		{
			int[] array = new int[i];
			var randomNumber = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));
			for (i = 0; i < array.Length; i++)
				array[i] = randomNumber.Next();
			return array;
		}
	}
}
