using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Declares a collection of constant lines belonging to the value axis.</summary>
	public class ChartValueAxisConstantLineBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public ChartValueAxisConstantLineBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartValueAxisConstantLineBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of constant lines.</summary>
		[Generated]
		public ChartValueAxisConstantLineBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of constant lines.</summary>
		[Generated]
		public ChartValueAxisConstantLineBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of constant lines.</summary>
		[Generated]
		public ChartValueAxisConstantLineBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Specifies whether to display the constant line behind or in front of the series.</summary>
		[Generated]
		public ChartValueAxisConstantLineBuilder DisplayBehindSeries(bool value)
		{
			base.Options["displayBehindSeries"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the constant line behind or in front of the series.</summary>
		[Generated]
		public ChartValueAxisConstantLineBuilder DisplayBehindSeries(JS value)
		{
			base.Options["displayBehindSeries"] = value;
			return this;
		}

		/// <summary>Specifies whether to extend the axis's default visual range to display the constant line.</summary>
		[Generated]
		public ChartValueAxisConstantLineBuilder ExtendAxis(bool value)
		{
			base.Options["extendAxis"] = value;
			return this;
		}

		/// <summary>Specifies whether to extend the axis's default visual range to display the constant line.</summary>
		[Generated]
		public ChartValueAxisConstantLineBuilder ExtendAxis(JS value)
		{
			base.Options["extendAxis"] = value;
			return this;
		}

		/// <summary>Configures the constant line label.</summary>
		[Generated]
		public ChartValueAxisConstantLineBuilder Label(Action<ChartValueAxisConstantLinesLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the left/right side of a constant line and the constant line label.</summary>
		[Generated]
		public ChartValueAxisConstantLineBuilder PaddingLeftRight(double value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the left/right side of a constant line and the constant line label.</summary>
		[Generated]
		public ChartValueAxisConstantLineBuilder PaddingLeftRight(JS value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the top/bottom side of a constant line and the constant line label.</summary>
		[Generated]
		public ChartValueAxisConstantLineBuilder PaddingTopBottom(double value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the top/bottom side of a constant line and the constant line label.</summary>
		[Generated]
		public ChartValueAxisConstantLineBuilder PaddingTopBottom(JS value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Specifies the value indicated by a constant line. Setting this option is necessary.</summary>
		[Generated]
		public ChartValueAxisConstantLineBuilder Value(DateTime value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the value indicated by a constant line. Setting this option is necessary.</summary>
		[Generated]
		public ChartValueAxisConstantLineBuilder Value(double value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the value indicated by a constant line. Setting this option is necessary.</summary>
		[Generated]
		public ChartValueAxisConstantLineBuilder Value(string value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the value indicated by a constant line. Setting this option is necessary.</summary>
		[Generated]
		public ChartValueAxisConstantLineBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the width of constant lines in pixels.</summary>
		[Generated]
		public ChartValueAxisConstantLineBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of constant lines in pixels.</summary>
		[Generated]
		public ChartValueAxisConstantLineBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
