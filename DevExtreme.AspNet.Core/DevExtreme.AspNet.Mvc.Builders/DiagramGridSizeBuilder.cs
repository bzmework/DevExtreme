using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the grid pitch.</summary>
	public class DiagramGridSizeBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DiagramGridSizeBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DiagramGridSizeBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>An array that specifies the grid size items in the _Grid Size_ combobox on 'Properties' panel.</summary>
		[Generated]
		public DiagramGridSizeBuilder Items(IEnumerable<double> value)
		{
			base.Options["items"] = value;
			return this;
		}

		/// <summary>An array that specifies the grid size items in the _Grid Size_ combobox on 'Properties' panel.</summary>
		[Generated]
		public DiagramGridSizeBuilder Items(JS value)
		{
			base.Options["items"] = value;
			return this;
		}

		/// <summary>Specifies the grid pitch.</summary>
		[Generated]
		public DiagramGridSizeBuilder Value(double value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the grid pitch.</summary>
		[Generated]
		public DiagramGridSizeBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}
	}
}
