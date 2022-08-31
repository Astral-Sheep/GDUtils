﻿using Godot;

namespace Com.Surbon.GDUtils
{
	public static class ColorT
	{
		public static readonly Color NONE = new Color(0, 0, 0, 0);
		public static readonly Color Black = new Color(0, 0, 0, 1);
		public static readonly Color White = new Color(1, 1, 1, 1);
		public static readonly Color Red = new Color(1, 0, 0, 1);
		public static readonly Color Yellow = new Color(1, 1, 0, 1);
		public static readonly Color Green = new Color(0, 1, 0, 1);
		public static readonly Color Cyan = new Color(0, 1, 1, 1);
		public static readonly Color Blue = new Color(0, 0, 1, 1);
		public static readonly Color Pink = new Color(1, 0, 1, 1);

		public static Color GetGray(Color color)
		{
			float gray = (color.r + color.g + color.b) / 3f;
			return new Color(gray, gray, gray, color.a);
		}

		public static Color SetAlpha(Color color, float a)
		{
			return new Color(color.r, color.g, color.b, a);
		}

		public static Color SetBlue(Color color, float b)
		{
			return new Color(color.r, color.g, b, color.a);
		}

		public static Color SetGreen(Color color, float g)
		{
			return new Color(color.r, g, color.b, color.a);
		}

		public static Color SetRed(Color color, float r)
		{
			return new Color(r, color.g, color.b, color.a);
		}

		public static Color SetVisible(Color color, bool isVisible)
		{
			return SetAlpha(color, isVisible ? 1f : 0f);
		}
	}
}
