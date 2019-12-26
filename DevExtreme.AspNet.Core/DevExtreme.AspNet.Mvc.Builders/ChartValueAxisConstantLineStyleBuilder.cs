using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the appearance of those constant lines that belong to the value axis.</summary>
	public class ChartValueAxisConstantLineStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartValueAxisConstantLineStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartValueAxisConstantLineStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of constant lines.</summary>
		[Generated]
		public ChartValueAxisConstantLineStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of constant lines.</summary>
		[Generated]
		public ChartValueAxisConstantLineStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of constant lines.</summary>
		[Generated]
		public ChartValueAxisConstantLineStyleBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Specifies the appearance of the labels of those constant lines that belong to the value axis.</summary>
		[Generated]
		public ChartValueAxisConstantLineStyleBuilder Label(Action<ChartValueAxisConstantLineStyleLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the left/right side of a constant line and the constant line label.</summary>
		[Generated]
		public ChartValueAxisConstantLineStyleBuilder PaddingLeftRight(double value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the left/right side of a constant line and the constant line label.</summary>
		[Generated]
		public ChartValueAxisConstantLineStyleBuilder PaddingLeftRight(JS value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the top/bottom side of a constant line and the constant line label.</summary>
		[Generated]
		public ChartValueAxisConstantLineStyleBuilder PaddingTopBottom(double value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the top/bottom side of a constant line and the constant line label.</summary>
		[Generated]
		public ChartValueAxisConstantLineStyleBuilder PaddingTopBottom(JS value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Specifies the width of constant lines in pixels.</summary>
		[Generated]
		public ChartValueAxisConstantLineStyleBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of constant lines in pixels.</summary>
		[Generated]
		public ChartValueAxisConstantLineStyleBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
