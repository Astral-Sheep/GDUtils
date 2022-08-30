using Godot;
using System;

namespace Com.Surbon.GDUtils.Math
{
	public static class MathT
	{
		/// <summary>
		/// Returns the euclidian quotient of a / b.
		/// </summary>
		public static float EuclidianQuotient(float a, float b) => Mathf.Floor(a / b);

		/// <summary>
		/// Returns the euclidian remainder of a / b.
		/// </summary>
		public static float EuclidianRemainder(float a, float b) => a - EuclidianQuotient(a, b) * b;

		/// <summary>
		/// Returns the euclidian remainder of a / b.
		/// </summary>
		public static int EuclidianRemainder(int a, int b) => a - (a / b) * b;

		/// <summary>
		/// Returns the factorial of the given number.
		/// </summary>
		public static int Factorial(int value)
		{
			if (value < 0)
				throw new ArgumentOutOfRangeException("The value must be greater than 0.");

			int lFact = 1;

			for (int i = 2; i <= value; i++)
			{
				lFact *= i;
			}

			return lFact;
		}

		/// <summary>
		/// Linearly interpolates between to values by a random normalized ratio (between 0 and 1).
		/// </summary>
		public static float LerpRand(float a, float b) => LerpUnclamped(a, b, new RandomNumberGenerator().Randf());

		/// <summary>
		/// Linearly interpolates between to values by a given ratio.
		/// </summary>
		public static float LerpUnclamped(float a, float b, float ratio) => a + (b - a) * ratio;

		/// <summary>
		/// Returns a modulo b.
		/// </summary>
		/// <param name="a">The dividend.</param>
		/// <param name="b">The divisor.</param>
		/// <param name="isPos">If true, the remainder is negative.</param>
		public static float Mod(float a, float b, bool isPos = true) => EuclidianRemainder(a, b) - (isPos ? 0 : b);

		/// <summary>
		/// Returns a modulo b.
		/// </summary>
		/// <param name="a">The dividend.</param>
		/// <param name="b">The divisor.</param>
		/// <param name="isPos">If true, the remainder is negative.</param>
		public static int Mod(int a, int b, bool isPos = true) => EuclidianRemainder(a, b) - (isPos ? 0 : b);

		/// <summary>
		/// Returns a to the power of -b.
		/// </summary>
		public static float NegPow(float a, int b)
		{
			float pow = 1f;

			for (int i = 0; i < b; i++)
			{
				pow /= a;
			}

			return a;
		}

		/// <summary>
		/// Returns the nth root of the given number.
		/// </summary>
		public static float NRoot(float value, float n) => Mathf.Exp((1f / n) * Mathf.Log(value));

		/// <summary>
		/// Returns a to the power of b.
		/// </summary>
		public static float PosPow(float a, int b)
		{
			float pow = 1f;

			for (int i = 0; i < b; i++)
			{
				pow *= a;
			}

			return pow;
		}

		/// <summary>
		/// Returns a to the power of b.
		/// </summary>
		public static float Pow(float a, int b)
		{
			return b < 0 ? NegPow(a, -b) : PosPow(a, b);
		}
	}

	public static class VectorT
	{
		/// <summary>
		/// Set the length of the vector between the given min and max.
		/// </summary>
		public static Vector2 ClampLength(Vector2 vector, float min, float max)
		{
			float lLength = vector.LengthSquared();

			if (lLength < min * min) return Normalize(vector, min);
			else if (lLength > max * max) return Normalize(vector, max);
			return vector;
		}

		/// <summary>
		/// Set the length of the vector between the given min and max.
		/// </summary>
		public static Vector3 ClampLength(Vector3 vector, float min, float max)
		{
			float lLength = vector.LengthSquared();

			if (lLength < min * min) return Normalize(vector, min);
			else if (lLength > max * max) return Normalize(vector, max);
			return vector;
		}

		/// <summary>
		/// Sets the values of the vector between the given min and max.
		/// </summary>
		public static Vector2 ClampValues(Vector2 vector, float minX, float maxX, float minY, float maxY)
		{
			return new Vector2(
				Mathf.Clamp(vector.x, minX, maxX),
				Mathf.Clamp(vector.y, minY, maxY)
				);
		}

		/// <summary>
		/// Sets the values of the vector between the given min and max.
		/// </summary>
		public static Vector3 ClampValues(Vector3 vector, float minX, float maxX, float minY, float maxY, float minZ, float maxZ)
		{
			return new Vector3(
				Mathf.Clamp(vector.x, minX, maxX),
				Mathf.Clamp(vector.y, minY, maxY),
				Mathf.Clamp(vector.z, minZ, maxZ)
				);
		}

		/// <summary>
		/// Sets the values of the vector between the given min and max.
		/// </summary>
		public static Vector2 ClampValuesUniform(Vector2 vector, float min, float max)
		{
			return ClampValues(vector, min, max, min, max);
		}

		/// <summary>
		/// Sets the values of the vector between the given min and max.
		/// </summary>
		public static Vector3 ClampValuesUniform(Vector3 vector, float min, float max)
		{
			return ClampValues(vector, min, max, min, max, min, max);
		}

		/// <summary>
		/// Linearly interpolates to vectors by a normalized value.
		/// </summary>
		public static Vector2 Lerp(Vector2 from, Vector2 to, float weight)
		{
			return LerpUnclamped(from, to, Mathf.Clamp(weight, 0, 1));
		}

		/// <summary>
		/// Linearly interpolates to vectors by a normalized value.
		/// </summary>
		public static Vector3 Lerp(Vector3 from, Vector3 to, float weight)
		{
			return LerpUnclamped(from, to, Mathf.Clamp(weight, 0, 1));
		}

		/// <summary>
		/// Linearly interpolates two vectors by a normalized random value.
		/// </summary>
		public static Vector2 LerpRand(Vector2 from, Vector2 to)
		{
			float lRandom = new RandomNumberGenerator().Randf();

			return LerpUnclamped(from, to, lRandom);
		}

		/// <summary>
		/// Linearly interpolates two vectors by a normalized random value.
		/// </summary>
		public static Vector3 LerpRand(Vector3 from, Vector3 to)
		{
			float lRandom = new RandomNumberGenerator().Randf();

			return LerpUnclamped(from, to, lRandom);
		}

		/// <summary>
		/// Linearly interpolates two vectors by the given value.
		/// </summary>
		public static Vector2 LerpUnclamped(Vector2 from, Vector2 to, float weight)
		{
			return new Vector2(
				MathT.LerpUnclamped(from.x, to.x, weight),
				MathT.LerpUnclamped(from.y, to.y, weight)
				);
		}

		/// <summary>
		/// Linearly interpolates two vectors by the given value.
		/// </summary>
		public static Vector3 LerpUnclamped(Vector3 from, Vector3 to, float weight)
		{
			return new Vector3(
				MathT.LerpUnclamped(from.x, to.x, weight),
				MathT.LerpUnclamped(from.y, to.y, weight),
				MathT.LerpUnclamped(from.z, to.z, weight)
				);
		}

		/// <summary>
		/// Normalize the length of the vector to the given length.
		/// </summary>
		public static Vector2 Normalize(Vector2 vector, float length = 1)
		{
			return vector.Normalized() * length;
		}

		/// <summary>
		/// Normalize the length of the vector to the given length.
		/// </summary>
		public static Vector3 Normalize(Vector3 vector, float length = 1)
		{
			return vector.Normalized() * length;
		}
	}
}
