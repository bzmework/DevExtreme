namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Strings that can be changed or localized in the pivot grid's integrated Field Chooser.</summary>
	public class PivotGridFieldChooserTextsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PivotGridFieldChooserTextsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PivotGridFieldChooserTextsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>The string to display instead of All Fields.</summary>
		[Generated]
		public PivotGridFieldChooserTextsBuilder AllFields(string value)
		{
			base.Options["allFields"] = value;
			return this;
		}

		/// <summary>The string to display instead of All Fields.</summary>
		[Generated]
		public PivotGridFieldChooserTextsBuilder AllFields(JS value)
		{
			base.Options["allFields"] = value;
			return this;
		}

		/// <summary>The string to display instead of Column Fields.</summary>
		[Generated]
		public PivotGridFieldChooserTextsBuilder ColumnFields(string value)
		{
			base.Options["columnFields"] = value;
			return this;
		}

		/// <summary>The string to display instead of Column Fields.</summary>
		[Generated]
		public PivotGridFieldChooserTextsBuilder ColumnFields(JS value)
		{
			base.Options["columnFields"] = value;
			return this;
		}

		/// <summary>The string to display instead of Data Fields.</summary>
		[Generated]
		public PivotGridFieldChooserTextsBuilder DataFields(string value)
		{
			base.Options["dataFields"] = value;
			return this;
		}

		/// <summary>The string to display instead of Data Fields.</summary>
		[Generated]
		public PivotGridFieldChooserTextsBuilder DataFields(JS value)
		{
			base.Options["dataFields"] = value;
			return this;
		}

		/// <summary>The string to display instead of Filter Fields.</summary>
		[Generated]
		public PivotGridFieldChooserTextsBuilder FilterFields(string value)
		{
			base.Options["filterFields"] = value;
			return this;
		}

		/// <summary>The string to display instead of Filter Fields.</summary>
		[Generated]
		public PivotGridFieldChooserTextsBuilder FilterFields(JS value)
		{
			base.Options["filterFields"] = value;
			return this;
		}

		/// <summary>The string to display instead of Row Fields.</summary>
		[Generated]
		public PivotGridFieldChooserTextsBuilder RowFields(string value)
		{
			base.Options["rowFields"] = value;
			return this;
		}

		/// <summary>The string to display instead of Row Fields.</summary>
		[Generated]
		public PivotGridFieldChooserTextsBuilder RowFields(JS value)
		{
			base.Options["rowFields"] = value;
			return this;
		}
	}
}
