using Godot;
using System;

namespace Com.Surbon.GDUtils.Math
{
	public static class RandomT
	{
		private static RandomNumberGenerator inclusiveGenerator;
		private static Random exclusiveGenerator;

		static RandomT()
		{
			exclusiveGenerator = new Random();
			inclusiveGenerator = new RandomNumberGenerator();
			inclusiveGenerator.Randomize();
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

		/// <summary>
		/// Returns a random integer between min and min ([min, max[).
		/// </summary>
		public static float RandiExclusive(int min = 0, int max = 1)
		{
			return exclusiveGenerator.Next(min, max);
		}

		/// <summary>
		/// Returns a random integer between min and min ([min, max]).
		/// </summary>
		public static float RandiInclusive(int min = 0, int max = 1)
		{
			return inclusiveGenerator.RandiRange(min, max);
		}
	}
}
