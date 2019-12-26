namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the widget's size in pixels.</summary>
	public class CircularGaugeSizeBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public CircularGaugeSizeBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public CircularGaugeSizeBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the height of the widget in pixels.</summary>
		[Generated]
		public CircularGaugeSizeBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the height of the widget in pixels.</summary>
		[Generated]
		public CircularGaugeSizeBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the width of the widget in pixels.</summary>
		[Generated]
		public CircularGaugeSizeBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the widget in pixels.</summary>
		[Generated]
		public CircularGaugeSizeBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
