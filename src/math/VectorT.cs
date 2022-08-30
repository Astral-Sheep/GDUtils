using Godot;

namespace Com.Surbon.GDUtils.Math
{
	public static class VectorT
	{
		/// <summary>
		 /// Returns the cylindric coordinates of the vector from the cartesian coordinates
		 /// </summary>
		 /// <param name="vector">Cartesian coordinates as (x, y, z)</param>
		 /// <returns>Cylindric coordinates as (r, phi, z)</returns>
		public static Vector3 CartesianToCylindric(Vector3 vector)
		{
			Vector2 lPolarVector = Mathf.Cartesian2Polar(vector.x, vector.y);

			return new Vector3(lPolarVector.x, lPolarVector.y, vector.z);
		}

		/// <summary>
		/// Returns the cylindric coordinates of the vector given in cartesian coordinates
		/// </summary>
		/// <param name="x">Cartesian coordinate x</param>
		/// <param name="y">Cartesian coordinate y</param>
		/// <param name="z">Cartesian coordinate z</param>
		/// <returns>Cylindric coordinates as (r, phi, z)</returns>
		public static Vector3 CartesianToCylindric(float x, float y, float z)
		{
			Vector2 lPolarVector = Mathf.Cartesian2Polar(x, y);

			return new Vector3(lPolarVector.x, lPolarVector.y, z);
		}

		/// <summary>
		/// Returns the spheric coordinates of the vector from the cartesian coordinates
		/// </summary>
		/// <param name="vector">Cartesian coordinates as (x, y, z)</param>
		/// <returns>Spheric coordinates as (rho, phi, th)</returns>
		public static Vector3 CartesianToSpheric(Vector3 vector)
		{
			return new Vector3(
				vector.Length(),
				Mathf.Atan2(vector.y, vector.x),
				Mathf.Atan2(vector.z, new Vector2(vector.x, vector.y).Length())
				);
		}

		/// <summary>
		/// Returns the spheric coordinates of the vector from the cartesian coordinates
		/// </summary>
		/// <param name="x">Cartesian coordinate x</param>
		/// <param name="y">Cartesian coordinate y</param>
		/// <param name="z">Cartesian coordinate z</param>
		/// <returns>Spheric coordinates as (rho, phi, th)</returns>
		public static Vector3 CartesianToSpheric(float x, float y, float z)
		{
			return new Vector3(
				new Vector3(x, y, z).Length(),
				Mathf.Atan2(y, x),
				Mathf.Atan2(z, new Vector2(x, y).Length())
				);
		}


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
		/// Returns the cartesian coordinates of the vector given in cylindric coordinates
		/// </summary>
		/// <param name="vector">Cylindric coordinates as (r, phi, z)</param>
		/// <returns>Cartesian coordinates as (x, y, z)</returns>
		public static Vector3 CylindricToCartesian(Vector3 vector)
		{
			Vector2 lCartesianVector = Mathf.Polar2Cartesian(vector.x, vector.y);

			return new Vector3(lCartesianVector.x, lCartesianVector.y, vector.z);
		}

		/// <summary>
		/// Returns the cartesian coordinates of the vector given in cylindric coordinates
		/// </summary>
		/// <param name="r">Polar radius</param>
		/// <param name="phi">Azimuth angle</param>
		/// <param name="z">Cartesian coordinate z</param>
		/// <returns>Cartesian coordinates as (x, y, z)</returns>
		public static Vector3 CylindricToCartesian(float r, float phi, float z)
		{
			Vector2 lCartesianVector = Mathf.Polar2Cartesian(r, phi);

			return new Vector3(lCartesianVector.x, lCartesianVector.y, z);
		}

		/// <summary>
		/// Returns the spheric coordinates of the vector given in cylindric coordinates
		/// </summary>
		/// <param name="vector">Cylindric coordinates as (r, phi, z)</param>
		/// <returns>Spheric coordinates as (rho, phi, th)</returns>
		public static Vector3 CylindricToSpheric(Vector3 vector)
		{
			return new Vector3(
				new Vector2(vector.x, vector.z).Length(),
				vector.y,
				Mathf.Atan2(vector.z, vector.x)
				);
		}

		/// <summary>
		/// Returns the spheric coordinates of the vector given in cylindric coordinates
		/// </summary>
		/// <param name="r">Polar radius</param>
		/// <param name="phi">Azimuth angle</param>
		/// <param name="z">Cartesian coordinate z</param>
		/// <returns>Spheric coordinates as (rho, phi, th)</returns>
		public static Vector3 CylindricToSpheric(float r, float phi, float z)
		{
			return new Vector3(
				new Vector2(r, z).Length(),
				phi,
				Mathf.Atan2(z, r)
				);
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

		/// <summary>
		/// Returns the cartesian coordinates of the vector given in spheric coordinates
		/// </summary>
		/// <param name="vector">Spheric coordinates as (rho, phi, th)</param>
		/// <returns>Cartesian coordinates as (x, y, z)</returns>
		public static Vector3 SphericToCartesian(Vector3 vector)
		{
			return new Vector3(
				vector.x * Mathf.Cos(vector.y) * Mathf.Sin(vector.z),
				vector.x * Mathf.Sin(vector.y) * Mathf.Sin(vector.z),
				vector.x * Mathf.Cos(vector.z)
				);
		}

		/// <summary>
		/// Returns the cartesian coordinates of the vector given in spheric coordinates
		/// </summary>
		/// <param name="rho">Spheric radius</param>
		/// <param name="phi">Azimuth angle</param>
		/// <param name="th">Polar angle</param>
		/// <returns>Cartesian coordinates as (x, y, z)</returns>
		public static Vector3 SphericToCartesian(float rho, float phi, float th)
		{
			return new Vector3(
				rho * Mathf.Cos(phi) * Mathf.Sin(th),
				rho * Mathf.Sin(phi) * Mathf.Sin(th),
				rho * Mathf.Cos(th)
				);
		}

		/// <summary>
		/// Returns the cylindric coordinates of the vector given in spheric coordinates
		/// </summary>
		/// <param name="vector">Spheric coordinates as (rho, phi, th)</param>
		/// <returns>Cylindric coordinates as (r, phi, z)</returns>
		public static Vector3 SphericToCylindric(Vector3 vector)
		{
			return new Vector3(
				vector.x * Mathf.Sin(vector.z),
				vector.y,
				vector.x * Mathf.Cos(vector.z)
				);
		}

		/// <summary>
		/// Returns the cylindric coordinates of the vector given in spheric coordinates
		/// </summary>
		/// <param name="rho">Spheric radius</param>
		/// <param name="phi">Azimuth angle</param>
		/// <param name="th">Polar angle</param>
		/// <returns>Cylindric coordinates as (r, phi, z)</returns>
		public static Vector3 SphericToCylindric(float rho, float phi, float th)
		{
			return new Vector3(
				rho * Mathf.Sin(th),
				phi,
				rho * Mathf.Cos(th)
				);
		}
	}
}
