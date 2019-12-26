namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the field's header filter.</summary>
	public class PivotGridDataSourceFieldsHeaderFilterBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PivotGridDataSourceFieldsHeaderFilterBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PivotGridDataSourceFieldsHeaderFilterBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether searching is enabled in the header filter.</summary>
		[Generated]
		public PivotGridDataSourceFieldsHeaderFilterBuilder AllowSearch(bool value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies whether searching is enabled in the header filter.</summary>
		[Generated]
		public PivotGridDataSourceFieldsHeaderFilterBuilder AllowSearch(JS value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies the height of the popup menu containing filtering values.</summary>
		[Generated]
		public PivotGridDataSourceFieldsHeaderFilterBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the height of the popup menu containing filtering values.</summary>
		[Generated]
		public PivotGridDataSourceFieldsHeaderFilterBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the width of the popup menu containing filtering values.</summary>
		[Generated]
		public PivotGridDataSourceFieldsHeaderFilterBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the popup menu containing filtering values.</summary>
		[Generated]
		public PivotGridDataSourceFieldsHeaderFilterBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
