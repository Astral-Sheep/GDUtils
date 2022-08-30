using Godot;

namespace Com.Surbon.GDUtils.Math
{
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
		/// Returns the slope of the line passing by from and to.
		/// </summary>
		public static float GetSlope(Vector2 from, Vector2 to)
		{
			return (to.y - from.y) / (to.x - from.x);
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
			return LerpUnclamped(from, to, RandomT.RandfInclusive());
		}

		/// <summary>
		/// Linearly interpolates two vectors by a normalized random value.
		/// </summary>
		public static Vector3 LerpRand(Vector3 from, Vector3 to)
		{
			return LerpUnclamped(from, to, RandomT.RandfInclusive());
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
