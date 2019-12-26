using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures column fixing.</summary>
	public class DataGridColumnFixingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridColumnFixingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridColumnFixingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Enables column fixing.</summary>
		[Generated]
		public DataGridColumnFixingBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables column fixing.</summary>
		[Generated]
		public DataGridColumnFixingBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Contains options that specify texts for column fixing commands in the context menu of a column header.</summary>
		[Generated]
		public DataGridColumnFixingBuilder Texts(Action<DataGridColumnFixingTextsBuilder> configurator)
		{
			NestedOptions("texts", configurator);
			return this;
		}
	}
}
