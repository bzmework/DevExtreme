namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the scale breaks' appearance.</summary>
	public class ChartArgumentAxisBreakStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartArgumentAxisBreakStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartArgumentAxisBreakStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' color.</summary>
		[Generated]
		public ChartArgumentAxisBreakStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' color.</summary>
		[Generated]
		public ChartArgumentAxisBreakStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' line style.</summary>
		[Generated]
		public ChartArgumentAxisBreakStyleBuilder Line(ScaleBreakLineStyle value)
		{
			base.Options["line"] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' width in pixels.</summary>
		[Generated]
		public ChartArgumentAxisBreakStyleBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' width in pixels.</summary>
		[Generated]
		public ChartArgumentAxisBreakStyleBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
