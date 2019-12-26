using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies marker label options.</summary>
	public class VectorMapLayersLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public VectorMapLayersLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public VectorMapLayersLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>The name of the data source attribute containing marker texts.</summary>
		[Generated]
		public VectorMapLayersLabelBuilder DataField(string value)
		{
			base.Options["dataField"] = value;
			return this;
		}

		/// <summary>The name of the data source attribute containing marker texts.</summary>
		[Generated]
		public VectorMapLayersLabelBuilder DataField(JS value)
		{
			base.Options["dataField"] = value;
			return this;
		}

		/// <summary>Enables marker labels.</summary>
		[Generated]
		public VectorMapLayersLabelBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables marker labels.</summary>
		[Generated]
		public VectorMapLayersLabelBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies font options for marker labels.</summary>
		[Generated]
		public VectorMapLayersLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}
	}
}
