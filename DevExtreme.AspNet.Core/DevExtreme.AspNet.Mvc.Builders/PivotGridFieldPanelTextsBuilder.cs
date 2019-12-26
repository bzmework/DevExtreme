namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the placeholders of the field areas.</summary>
	public class PivotGridFieldPanelTextsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PivotGridFieldPanelTextsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PivotGridFieldPanelTextsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the placeholder of the column field area.</summary>
		[Generated]
		public PivotGridFieldPanelTextsBuilder ColumnFieldArea(string value)
		{
			base.Options["columnFieldArea"] = value;
			return this;
		}

		/// <summary>Specifies the placeholder of the column field area.</summary>
		[Generated]
		public PivotGridFieldPanelTextsBuilder ColumnFieldArea(JS value)
		{
			base.Options["columnFieldArea"] = value;
			return this;
		}

		/// <summary>Specifies the placeholder of the data field area.</summary>
		[Generated]
		public PivotGridFieldPanelTextsBuilder DataFieldArea(string value)
		{
			base.Options["dataFieldArea"] = value;
			return this;
		}

		/// <summary>Specifies the placeholder of the data field area.</summary>
		[Generated]
		public PivotGridFieldPanelTextsBuilder DataFieldArea(JS value)
		{
			base.Options["dataFieldArea"] = value;
			return this;
		}

		/// <summary>Specifies the placeholder of the filter field area.</summary>
		[Generated]
		public PivotGridFieldPanelTextsBuilder FilterFieldArea(string value)
		{
			base.Options["filterFieldArea"] = value;
			return this;
		}

		/// <summary>Specifies the placeholder of the filter field area.</summary>
		[Generated]
		public PivotGridFieldPanelTextsBuilder FilterFieldArea(JS value)
		{
			base.Options["filterFieldArea"] = value;
			return this;
		}

		/// <summary>Specifies the placeholder of the row field area.</summary>
		[Generated]
		public PivotGridFieldPanelTextsBuilder RowFieldArea(string value)
		{
			base.Options["rowFieldArea"] = value;
			return this;
		}

		/// <summary>Specifies the placeholder of the row field area.</summary>
		[Generated]
		public PivotGridFieldPanelTextsBuilder RowFieldArea(JS value)
		{
			base.Options["rowFieldArea"] = value;
			return this;
		}
	}
}
