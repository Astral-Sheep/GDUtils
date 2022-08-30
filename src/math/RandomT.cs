using Godot;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Surbon.GDUtils.src.math
{
	public static class RandomT
	{
		private static RandomNumberGenerator inclusiveGenerator;
		private static Random exclusiveGenerator;

		public static void Init()
		{
			inclusiveGenerator = new RandomNumberGenerator();
			inclusiveGenerator.Randomize();

			exclusiveGenerator = new Random();
		}

		/// <summary>
		/// Returns a random number between min and max ([min, max[).
		/// </summary>
		public static float RandfExclusive(float min = 0, float max = 1)
		{
			return min + (float)exclusiveGenerator.NextDouble() * (max - min);
		}

		/// <summary>
		/// Returns a random number between min and max ([min, max]).
		/// </summary>
		public static float RandfInclusive(float min = 0, float max = 1)
		{
			return inclusiveGenerator.RandfRange(min, max);
		}
	}
}
