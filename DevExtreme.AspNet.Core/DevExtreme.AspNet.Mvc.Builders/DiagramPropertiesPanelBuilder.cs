using DevExtreme.AspNet.Mvc.Factories;
using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Provides access to Properties panel settings.</summary>
	public class DiagramPropertiesPanelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DiagramPropertiesPanelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DiagramPropertiesPanelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether the Properties panel can be collapsed.</summary>
		[Generated]
		public DiagramPropertiesPanelBuilder Collapsible(bool value)
		{
			base.Options["collapsible"] = value;
			return this;
		}

		/// <summary>Specifies whether the Properties panel can be collapsed.</summary>
		[Generated]
		public DiagramPropertiesPanelBuilder Collapsible(JS value)
		{
			base.Options["collapsible"] = value;
			return this;
		}

		/// <summary>Specifies whether the Properties panel is available.</summary>
		[Generated]
		public DiagramPropertiesPanelBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the Properties panel is available.</summary>
		[Generated]
		public DiagramPropertiesPanelBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Contains an array of command groups in the Properties panel.</summary>
		[Generated]
		public DiagramPropertiesPanelBuilder Groups(Action<CollectionFactory<DiagramPropertiesPanelGroupBuilder>> configurator)
		{
			Collection("groups", configurator);
			return this;
		}
	}
}
