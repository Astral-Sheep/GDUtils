namespace Com.Surbon.GDUtils.Node
{
	/// <summary>
	/// Provides tools for <see cref="Godot.Node"/>
	/// </summary>
	public static class NodeT
	{
		/// <summary>
		/// Disable the process of the <see cref="Godot.Node"/> and all its children.
		/// </summary>
		public static void DisableProcess(Godot.Node node)
		{
			SetProcess(node, false);
		}

		/// <summary>
		/// Enable the process of the <see cref="Godot.Node"/> and all its children.
		/// </summary>
		public static void EnableProcess(Godot.Node node)
		{
			SetProcess(node, true);
		}

		/// <summary>
		/// Returns the nth parent of the given <see cref="Godot.Node"/>, or a null instance if the <see cref="Godot.Node"/> lacks parent. It returns the <see cref="Godot.Node"/>'s highest parent if it is below n.
		/// </summary>
		public static Godot.Node GetParent(Godot.Node node, int n)
		{
			Godot.Node lCurrentNode = node;
			Godot.Node lParent = null;

			for (int i = 0; i < n; i++)
			{
				lParent = lCurrentNode.GetParent();

				if (lParent == null) break;

				lCurrentNode = lParent;
			}

			if (lCurrentNode == node) return null;
			else if (lParent == null) return lCurrentNode;
			return lCurrentNode;
		}

		/// <summary>
		/// Returns the nth parent of the given <see cref="Godot.Node"/>, or a null instance if the <see cref="Godot.Node"/> lacks parent or its highest parent is below n.
		/// </summary>
		public static T GetParent<T>(Godot.Node node, int n) where T: Godot.Node
		{
			Godot.Node lCurrentNode = node;
			Godot.Node lParent = null;

			for (int i = 0; i < n; i++)
			{
				lParent = lCurrentNode.GetParent();

				if (lParent == null) return null;

				lCurrentNode = lParent;
			}

			return (T)lCurrentNode;
		}

		/// <summary>
		/// Sets the <see cref="Godot.Node._Process"/> of the given <see cref="Godot.Node"/> and all its children to the given <see cref="bool"/>.
		/// </summary>
		private static void SetProcess(Godot.Node node, bool isProcessing)
		{
			node.SetProcess(isProcessing);

			foreach (Godot.Node child in node.GetChildren())
			{
				SetProcess(child, isProcessing);
			}
		}
	}
}
