namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the cursor offset from the dragged row.</summary>
	public class TreeListRowDraggingCursorOffsetBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeListRowDraggingCursorOffsetBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListRowDraggingCursorOffsetBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the horizontal cursor offset from the dragged row in pixels.</summary>
		[Generated]
		public TreeListRowDraggingCursorOffsetBuilder X(double value)
		{
			base.Options["x"] = value;
			return this;
		}

		/// <summary>Specifies the horizontal cursor offset from the dragged row in pixels.</summary>
		[Generated]
		public TreeListRowDraggingCursorOffsetBuilder X(JS value)
		{
			base.Options["x"] = value;
			return this;
		}

		/// <summary>Specifies the vertical cursor offset from the dragged row in pixels.</summary>
		[Generated]
		public TreeListRowDraggingCursorOffsetBuilder Y(double value)
		{
			base.Options["y"] = value;
			return this;
		}

		/// <summary>Specifies the vertical cursor offset from the dragged row in pixels.</summary>
		[Generated]
		public TreeListRowDraggingCursorOffsetBuilder Y(JS value)
		{
			base.Options["y"] = value;
			return this;
		}
	}
}
