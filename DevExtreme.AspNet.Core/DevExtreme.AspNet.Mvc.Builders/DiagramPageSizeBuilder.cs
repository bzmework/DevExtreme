using DevExtreme.AspNet.Mvc.Factories;
using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies a size of pages.</summary>
	public class DiagramPageSizeBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DiagramPageSizeBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DiagramPageSizeBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the page height.</summary>
		[Generated]
		public DiagramPageSizeBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the page height.</summary>
		[Generated]
		public DiagramPageSizeBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>An array that specifies the page size items in the _Paze Size_ combobox on 'Properties' panel.</summary>
		[Generated]
		public DiagramPageSizeBuilder Items(Action<CollectionFactory<DiagramPageSizeItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>Specifies the page width.</summary>
		[Generated]
		public DiagramPageSizeBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the page width.</summary>
		[Generated]
		public DiagramPageSizeBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
