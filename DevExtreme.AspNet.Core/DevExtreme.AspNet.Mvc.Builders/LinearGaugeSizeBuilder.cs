namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the widget's size in pixels.</summary>
	public class LinearGaugeSizeBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public LinearGaugeSizeBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public LinearGaugeSizeBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the height of the widget in pixels.</summary>
		[Generated]
		public LinearGaugeSizeBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the height of the widget in pixels.</summary>
		[Generated]
		public LinearGaugeSizeBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the width of the widget in pixels.</summary>
		[Generated]
		public LinearGaugeSizeBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the widget in pixels.</summary>
		[Generated]
		public LinearGaugeSizeBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
