using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures grouping.</summary>
	public class DataGridGroupingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridGroupingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridGroupingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether the user can collapse grouped records in a grid or not.</summary>
		[Generated]
		public DataGridGroupingBuilder AllowCollapsing(bool value)
		{
			base.Options["allowCollapsing"] = value;
			return this;
		}

		/// <summary>Specifies whether the user can collapse grouped records in a grid or not.</summary>
		[Generated]
		public DataGridGroupingBuilder AllowCollapsing(JS value)
		{
			base.Options["allowCollapsing"] = value;
			return this;
		}

		/// <summary>Specifies whether groups appear expanded or not.</summary>
		[Generated]
		public DataGridGroupingBuilder AutoExpandAll(bool value)
		{
			base.Options["autoExpandAll"] = value;
			return this;
		}

		/// <summary>Specifies whether groups appear expanded or not.</summary>
		[Generated]
		public DataGridGroupingBuilder AutoExpandAll(JS value)
		{
			base.Options["autoExpandAll"] = value;
			return this;
		}

		/// <summary>Enables the user to group data using the context menu.</summary>
		[Generated]
		public DataGridGroupingBuilder ContextMenuEnabled(bool value)
		{
			base.Options["contextMenuEnabled"] = value;
			return this;
		}

		/// <summary>Enables the user to group data using the context menu.</summary>
		[Generated]
		public DataGridGroupingBuilder ContextMenuEnabled(JS value)
		{
			base.Options["contextMenuEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the event on which a group will be expanded/collapsed.</summary>
		[Generated]
		public DataGridGroupingBuilder ExpandMode(GridGroupingExpandMode value)
		{
			base.Options["expandMode"] = value;
			return this;
		}

		/// <summary>Defines the texts of grouping-related visual elements.</summary>
		[Generated]
		public DataGridGroupingBuilder Texts(Action<DataGridGroupingTextsBuilder> configurator)
		{
			NestedOptions("texts", configurator);
			return this;
		}
	}
}
