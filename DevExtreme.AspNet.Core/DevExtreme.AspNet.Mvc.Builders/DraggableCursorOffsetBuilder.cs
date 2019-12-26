namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the cursor offset from the dragged item.</summary>
	public class DraggableCursorOffsetBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DraggableCursorOffsetBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DraggableCursorOffsetBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the horizontal cursor offset from the dragged item in pixels.</summary>
		[Generated]
		public DraggableCursorOffsetBuilder X(double value)
		{
			base.Options["x"] = value;
			return this;
		}

		/// <summary>Specifies the horizontal cursor offset from the dragged item in pixels.</summary>
		[Generated]
		public DraggableCursorOffsetBuilder X(JS value)
		{
			base.Options["x"] = value;
			return this;
		}

		/// <summary>Specifies the vertical cursor offset from the dragged item in pixels.</summary>
		[Generated]
		public DraggableCursorOffsetBuilder Y(double value)
		{
			base.Options["y"] = value;
			return this;
		}

		/// <summary>Specifies the vertical cursor offset from the dragged item in pixels.</summary>
		[Generated]
		public DraggableCursorOffsetBuilder Y(JS value)
		{
			base.Options["y"] = value;
			return this;
		}
	}
}
