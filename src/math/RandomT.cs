using Godot;
using System;

namespace Com.Surbon.GDUtils.Math
{
	/// <summary>
	/// Contains static methods to get random <see cref="float"/> and <see cref="int"/>.
	/// </summary>
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
		/// Returns a random <see cref="float"/> between min and max ([min, max[).
		/// </summary>
		public static float RandfExclusive(float min = 0, float max = 1)
		{
			return min + (float)exclusiveGenerator.NextDouble() * (max - min);
		}

		/// <summary>
		/// Returns a random <see cref="float"/> between min and max ([min, max]).
		/// </summary>
		public static float RandfInclusive(float min = 0, float max = 1)
		{
			return inclusiveGenerator.RandfRange(min, max);
		}

		/// <summary>
		/// Returns a random <see cref="int"/> between min and min ([min, max[).
		/// </summary>
		public static int RandiExclusive(int min = 0, int max = 1)
		{
			return exclusiveGenerator.Next(min, max);
		}

		/// <summary>
		/// Returns a random <see cref="int"/> between min and min ([min, max]).
		/// </summary>
		public static int RandiInclusive(int min = 0, int max = 1)
		{
			return inclusiveGenerator.RandiRange(min, max);
		}
	}
}
