namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the cursor offset from the dragged item.</summary>
	public class SortableCursorOffsetBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SortableCursorOffsetBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SortableCursorOffsetBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the horizontal cursor offset from the dragged item in pixels.</summary>
		[Generated]
		public SortableCursorOffsetBuilder X(double value)
		{
			base.Options["x"] = value;
			return this;
		}

		/// <summary>Specifies the horizontal cursor offset from the dragged item in pixels.</summary>
		[Generated]
		public SortableCursorOffsetBuilder X(JS value)
		{
			base.Options["x"] = value;
			return this;
		}

		/// <summary>Specifies the vertical cursor offset from the dragged item in pixels.</summary>
		[Generated]
		public SortableCursorOffsetBuilder Y(double value)
		{
			base.Options["y"] = value;
			return this;
		}

		/// <summary>Specifies the vertical cursor offset from the dragged item in pixels.</summary>
		[Generated]
		public SortableCursorOffsetBuilder Y(JS value)
		{
			base.Options["y"] = value;
			return this;
		}
	}
}
