using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Provides access to toolbox settings.</summary>
	public class DiagramToolboxBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DiagramToolboxBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DiagramToolboxBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Lists toolbox groups.</summary>
		[Generated]
		public DiagramToolboxBuilder Groups(Action<CollectionFactory<DiagramToolboxGroupBuilder>> configurator)
		{
			Collection("groups", configurator);
			return this;
		}

		/// <summary>Lists toolbox groups.</summary>
		[Generated]
		public DiagramToolboxBuilder Groups(IEnumerable<DiagramShapeCategory> value)
		{
			base.Options["groups"] = value;
			return this;
		}

		/// <summary>Specifies the toolbox's visibility.</summary>
		[Generated]
		public DiagramToolboxBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the toolbox's visibility.</summary>
		[Generated]
		public DiagramToolboxBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
