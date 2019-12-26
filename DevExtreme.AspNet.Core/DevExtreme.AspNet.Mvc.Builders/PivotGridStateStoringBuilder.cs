namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>A configuration object specifying options related to state storing.</summary>
	public class PivotGridStateStoringBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PivotGridStateStoringBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PivotGridStateStoringBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a function that is executed on state loading. Applies only if the type is "custom".</summary>
		[Generated]
		public PivotGridStateStoringBuilder CustomLoad(string jsFunc)
		{
			AssignJS("customLoad", jsFunc);
			return this;
		}

		/// <summary>Specifies a function that is executed on state loading. Applies only if the type is "custom".</summary>
		[Generated]
		public PivotGridStateStoringBuilder CustomLoad(RazorBlock jsFunc)
		{
			return CustomLoad(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies a function that is executed on state saving. Applies only if the type is "custom".</summary>
		[Generated]
		public PivotGridStateStoringBuilder CustomSave(string jsFunc)
		{
			AssignJS("customSave", jsFunc);
			return this;
		}

		/// <summary>Specifies a function that is executed on state saving. Applies only if the type is "custom".</summary>
		[Generated]
		public PivotGridStateStoringBuilder CustomSave(RazorBlock jsFunc)
		{
			return CustomSave(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether or not a grid saves its state.</summary>
		[Generated]
		public PivotGridStateStoringBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a grid saves its state.</summary>
		[Generated]
		public PivotGridStateStoringBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies the delay between the last change of a grid state and the operation of saving this state in milliseconds.</summary>
		[Generated]
		public PivotGridStateStoringBuilder SavingTimeout(double value)
		{
			base.Options["savingTimeout"] = value;
			return this;
		}

		/// <summary>Specifies the delay between the last change of a grid state and the operation of saving this state in milliseconds.</summary>
		[Generated]
		public PivotGridStateStoringBuilder SavingTimeout(JS value)
		{
			base.Options["savingTimeout"] = value;
			return this;
		}

		/// <summary>Specifies a unique key to be used for storing the grid state.</summary>
		[Generated]
		public PivotGridStateStoringBuilder StorageKey(string value)
		{
			base.Options["storageKey"] = value;
			return this;
		}

		/// <summary>Specifies a unique key to be used for storing the grid state.</summary>
		[Generated]
		public PivotGridStateStoringBuilder StorageKey(JS value)
		{
			base.Options["storageKey"] = value;
			return this;
		}

		/// <summary>Specifies the type of storage to be used for state storing.</summary>
		[Generated]
		public PivotGridStateStoringBuilder Type(StateStoringType value)
		{
			base.Options["type"] = value;
			return this;
		}
	}
}
