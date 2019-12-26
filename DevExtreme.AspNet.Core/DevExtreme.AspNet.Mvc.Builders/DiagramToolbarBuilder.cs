using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Provides access to toolbar settings.</summary>
	public class DiagramToolbarBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DiagramToolbarBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DiagramToolbarBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Lists commands in the toolbar.</summary>
		[Generated]
		public DiagramToolbarBuilder Commands(IEnumerable<DiagramToolbarCommand> value)
		{
			base.Options["commands"] = value;
			return this;
		}

		/// <summary>Specifies the toolbar's visibility.</summary>
		[Generated]
		public DiagramToolbarBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the toolbar's visibility.</summary>
		[Generated]
		public DiagramToolbarBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
