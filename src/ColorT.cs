using Godot;

namespace Com.Surbon.GDUtils
{
	/// <summary>
	/// Provides constants and static methods for Color.
	/// </summary>
	public static class ColorT
	{
		/// <summary>
		/// Litteraly no color : (0, 0, 0, 0).
		/// </summary>
		public static readonly Color None = new Color(0, 0, 0, 0);
		/// <summary>
		/// Black : (0, 0, 0, 1).
		/// </summary>
		public static readonly Color Black = new Color(0, 0, 0, 1);
		/// <summary>
		/// White : (1, 1, 1, 1).
		/// </summary>
		public static readonly Color White = new Color(1, 1, 1, 1);
		/// <summary>
		/// Red : (1, 0, 0, 1).
		/// </summary>
		public static readonly Color Red = new Color(1, 0, 0, 1);
		/// <summary>
		/// Yellow : (1, 1, 0, 1).
		/// </summary>
		public static readonly Color Yellow = new Color(1, 1, 0, 1);
		/// <summary>
		/// Green : (0, 1, 0, 1).
		/// </summary>
		public static readonly Color Green = new Color(0, 1, 0, 1);
		/// <summary>
		/// Cyan : (0, 1, 1, 1).
		/// </summary>
		public static readonly Color Cyan = new Color(0, 1, 1, 1);
		/// <summary>
		/// Blue : (0, 0, 1, 1).
		/// </summary>
		public static readonly Color Blue = new Color(0, 0, 1, 1);
		/// <summary>
		/// Pink : (1, 0, 1, 1).
		/// </summary>
		public static readonly Color Pink = new Color(1, 0, 1, 1);
		
		/// <summary>
		/// Returns the tint of gray corresponding to the given <see cref="Color"/>.
		/// </summary>
		public static Color GetGray(Color color)
		{
			float gray = (color.r + color.g + color.b) / 3f;
			return new Color(gray, gray, gray, color.a);
		}

		/// <summary>
		/// Sets the alpha property (<see cref="Color.a"/>) of the given <see cref="Color"/>.
		/// </summary>
		public static Color SetAlpha(Color color, float a)
		{
			return new Color(color.r, color.g, color.b, a);
		}

		/// <summary>
		/// Sets the blue property (<see cref="Color.b"/>) of the given <see cref="Color"/>.
		/// </summary>
		public static Color SetBlue(Color color, float b)
		{
			return new Color(color.r, color.g, b, color.a);
		}

		/// <summary>
		/// Sets the green property (<see cref="Color.g"/>) of the given <see cref="Color"/>.
		/// </summary>
		public static Color SetGreen(Color color, float g)
		{
			return new Color(color.r, g, color.b, color.a);
		}

		/// <summary>
		/// Sets the red property (<see cref="Color.r"/>) of the given <see cref="Color"/>.
		/// </summary>
		public static Color SetRed(Color color, float r)
		{
			return new Color(r, color.g, color.b, color.a);
		}

		/// <summary>
		/// Sets the alpha property (<see cref="Color.a"/>) of the given <see cref="Color"/> to 1 if isVisible is true or to 0.
		/// </summary>
		public static Color SetVisible(Color color, bool isVisible = true)
		{
			return SetAlpha(color, isVisible ? 1f : 0f);
		}
	}
}
