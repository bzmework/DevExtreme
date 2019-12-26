using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Defines an array of the argument axis constant lines.</summary>
	public class PolarChartArgumentAxisConstantLineBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public PolarChartArgumentAxisConstantLineBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLineBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color for a constant line.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLineBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color for a constant line.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLineBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a dash style for a constant line.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLineBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Specifies whether to display the constant line behind or in front of the series.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLineBuilder DisplayBehindSeries(bool value)
		{
			base.Options["displayBehindSeries"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the constant line behind or in front of the series.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLineBuilder DisplayBehindSeries(JS value)
		{
			base.Options["displayBehindSeries"] = value;
			return this;
		}

		/// <summary>Specifies whether to extend the axis to display the constant line.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLineBuilder ExtendAxis(bool value)
		{
			base.Options["extendAxis"] = value;
			return this;
		}

		/// <summary>Specifies whether to extend the axis to display the constant line.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLineBuilder ExtendAxis(JS value)
		{
			base.Options["extendAxis"] = value;
			return this;
		}

		/// <summary>An object defining constant line label options.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLineBuilder Label(Action<PolarChartArgumentAxisConstantLinesLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies a value to be displayed by a constant line.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLineBuilder Value(DateTime value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies a value to be displayed by a constant line.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLineBuilder Value(double value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies a value to be displayed by a constant line.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLineBuilder Value(string value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies a value to be displayed by a constant line.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLineBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies a constant line width in pixels.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLineBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies a constant line width in pixels.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLineBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
