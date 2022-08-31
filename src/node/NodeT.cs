namespace Com.Surbon.GDUtils.Node
{
	public static class NodeT
	{
		/// <summary>
		/// Disable the process of the node and all its children.
		/// </summary>
		public static void DisableProcess(Godot.Node node)
		{
			SetProcess(node, false);
		}

		/// <summary>
		/// Enable the process of the node and all its children.
		/// </summary>
		public static void EnableProcess(Godot.Node node)
		{
			SetProcess(node, true);
		}

		/// <summary>
		/// Returns the nth parent of the given node, or a null instance if the node lacks parent. It returns the node's highest parent if it is below n.
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
		/// Returns the nth parent of the given node, or a null instance if the node lacks parent or its highest parent is below n.
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
		/// Sets the process of the given node and all its children to the given boolean.
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
