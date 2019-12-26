namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the scale breaks' appearance.</summary>
	public class ChartValueAxisBreakStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartValueAxisBreakStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartValueAxisBreakStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' color.</summary>
		[Generated]
		public ChartValueAxisBreakStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' color.</summary>
		[Generated]
		public ChartValueAxisBreakStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' line style.</summary>
		[Generated]
		public ChartValueAxisBreakStyleBuilder Line(ScaleBreakLineStyle value)
		{
			base.Options["line"] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' width in pixels.</summary>
		[Generated]
		public ChartValueAxisBreakStyleBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' width in pixels.</summary>
		[Generated]
		public ChartValueAxisBreakStyleBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
