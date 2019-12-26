using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the zoom level.</summary>
	public class DiagramZoomLevelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DiagramZoomLevelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DiagramZoomLevelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>An array that specifies the zoom level items in the _Zoom Level_ combobox on 'Properties' panel.</summary>
		[Generated]
		public DiagramZoomLevelBuilder Items(IEnumerable<double> value)
		{
			base.Options["items"] = value;
			return this;
		}

		/// <summary>An array that specifies the zoom level items in the _Zoom Level_ combobox on 'Properties' panel.</summary>
		[Generated]
		public DiagramZoomLevelBuilder Items(JS value)
		{
			base.Options["items"] = value;
			return this;
		}

		/// <summary>Specifies the zoom level.</summary>
		[Generated]
		public DiagramZoomLevelBuilder Value(double value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the zoom level.</summary>
		[Generated]
		public DiagramZoomLevelBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}
	}
}
