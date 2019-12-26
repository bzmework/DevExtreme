using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Declares a collection of constant lines belonging to the argument axis.</summary>
	public class ChartArgumentAxisConstantLineBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public ChartArgumentAxisConstantLineBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of constant lines.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of constant lines.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of constant lines.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Specifies whether to display the constant line behind or in front of the series.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineBuilder DisplayBehindSeries(bool value)
		{
			base.Options["displayBehindSeries"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the constant line behind or in front of the series.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineBuilder DisplayBehindSeries(JS value)
		{
			base.Options["displayBehindSeries"] = value;
			return this;
		}

		/// <summary>Specifies whether to extend the axis's default visual range to display the constant line.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineBuilder ExtendAxis(bool value)
		{
			base.Options["extendAxis"] = value;
			return this;
		}

		/// <summary>Specifies whether to extend the axis's default visual range to display the constant line.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineBuilder ExtendAxis(JS value)
		{
			base.Options["extendAxis"] = value;
			return this;
		}

		/// <summary>Configures the constant line label.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineBuilder Label(Action<ChartArgumentAxisConstantLinesLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the left/right side of a constant line and the constant line label.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineBuilder PaddingLeftRight(double value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the left/right side of a constant line and the constant line label.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineBuilder PaddingLeftRight(JS value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the top/bottom side of a constant line and the constant line label.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineBuilder PaddingTopBottom(double value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the top/bottom side of a constant line and the constant line label.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineBuilder PaddingTopBottom(JS value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Specifies the value indicated by a constant line. Setting this option is necessary.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineBuilder Value(DateTime value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the value indicated by a constant line. Setting this option is necessary.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineBuilder Value(double value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the value indicated by a constant line. Setting this option is necessary.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineBuilder Value(string value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the value indicated by a constant line. Setting this option is necessary.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the width of constant lines in pixels.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of constant lines in pixels.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
