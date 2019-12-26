using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Contains an array of command groups in the Properties panel.</summary>
	public class DiagramPropertiesPanelGroupBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public DiagramPropertiesPanelGroupBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DiagramPropertiesPanelGroupBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Lists commands in a group.</summary>
		[Generated]
		public DiagramPropertiesPanelGroupBuilder Commands(IEnumerable<DiagramPropertiesPanelCommand> value)
		{
			base.Options["commands"] = value;
			return this;
		}
	}
}
