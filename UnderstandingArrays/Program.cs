﻿using System;

namespace UnderstandingArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			int[] numbers = new int[5];

			numbers[0] = 4;
			numbers[1] = 8;
			numbers[2] = 15;
			numbers[3] = 16;
			numbers[4] = 23;

			Console.WriteLine(numbers[1]);
			Console.WriteLine(numbers.Length);
			*/

			/*
			int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };
			string[] names = { "Eddie", "Alex", "Michael", "David Lee" };

			for (int i = 0; i < names.Length; i++)
			{
				Console.WriteLine(names[i]);
			}

			foreach (string e in names)
			{
				Console.WriteLine(e);
			}
			*/

			string zig = "You can get what you want out of life " +
				" if you help enough other people get what they want.";

			char[] charArr = zig.ToCharArray();
			Array.Reverse(charArr);

			foreach (char c in charArr)
			{
				Console.Write(c);
			}
			Console.WriteLine();
		}
	}
}
