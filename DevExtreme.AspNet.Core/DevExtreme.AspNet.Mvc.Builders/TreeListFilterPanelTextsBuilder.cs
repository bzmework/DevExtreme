namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies texts for the filter panel's elements.</summary>
	public class TreeListFilterPanelTextsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeListFilterPanelTextsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListFilterPanelTextsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>The text of the "Clear" link.</summary>
		[Generated]
		public TreeListFilterPanelTextsBuilder ClearFilter(string value)
		{
			base.Options["clearFilter"] = value;
			return this;
		}

		/// <summary>The text of the "Clear" link.</summary>
		[Generated]
		public TreeListFilterPanelTextsBuilder ClearFilter(JS value)
		{
			base.Options["clearFilter"] = value;
			return this;
		}

		/// <summary>The text of the "Create Filter" link.</summary>
		[Generated]
		public TreeListFilterPanelTextsBuilder CreateFilter(string value)
		{
			base.Options["createFilter"] = value;
			return this;
		}

		/// <summary>The text of the "Create Filter" link.</summary>
		[Generated]
		public TreeListFilterPanelTextsBuilder CreateFilter(JS value)
		{
			base.Options["createFilter"] = value;
			return this;
		}

		/// <summary>The hint of the checkbox that applies the filter.</summary>
		[Generated]
		public TreeListFilterPanelTextsBuilder FilterEnabledHint(string value)
		{
			base.Options["filterEnabledHint"] = value;
			return this;
		}

		/// <summary>The hint of the checkbox that applies the filter.</summary>
		[Generated]
		public TreeListFilterPanelTextsBuilder FilterEnabledHint(JS value)
		{
			base.Options["filterEnabledHint"] = value;
			return this;
		}
	}
}
