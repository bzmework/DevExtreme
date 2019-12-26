using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures column fixing.</summary>
	public class TreeListColumnFixingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeListColumnFixingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListColumnFixingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Enables column fixing.</summary>
		[Generated]
		public TreeListColumnFixingBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables column fixing.</summary>
		[Generated]
		public TreeListColumnFixingBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Contains options that specify texts for column fixing commands in the context menu of a column header.</summary>
		[Generated]
		public TreeListColumnFixingBuilder Texts(Action<TreeListColumnFixingTextsBuilder> configurator)
		{
			NestedOptions("texts", configurator);
			return this;
		}
	}
}
