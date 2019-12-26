namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures state storing.</summary>
	public class DataGridStateStoringBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridStateStoringBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridStateStoringBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a function that is executed on state loading. Applies only if the type is 'custom'.</summary>
		[Generated]
		public DataGridStateStoringBuilder CustomLoad(string jsFunc)
		{
			AssignJS("customLoad", jsFunc);
			return this;
		}

		/// <summary>Specifies a function that is executed on state loading. Applies only if the type is 'custom'.</summary>
		[Generated]
		public DataGridStateStoringBuilder CustomLoad(RazorBlock jsFunc)
		{
			return CustomLoad(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies a function that is executed on state saving. Applies only if the type is "custom".</summary>
		[Generated]
		public DataGridStateStoringBuilder CustomSave(string jsFunc)
		{
			AssignJS("customSave", jsFunc);
			return this;
		}

		/// <summary>Specifies a function that is executed on state saving. Applies only if the type is "custom".</summary>
		[Generated]
		public DataGridStateStoringBuilder CustomSave(RazorBlock jsFunc)
		{
			return CustomSave(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Enables state storing.</summary>
		[Generated]
		public DataGridStateStoringBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables state storing.</summary>
		[Generated]
		public DataGridStateStoringBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies the delay in milliseconds between when a user makes a change and when this change is saved.</summary>
		[Generated]
		public DataGridStateStoringBuilder SavingTimeout(double value)
		{
			base.Options["savingTimeout"] = value;
			return this;
		}

		/// <summary>Specifies the delay in milliseconds between when a user makes a change and when this change is saved.</summary>
		[Generated]
		public DataGridStateStoringBuilder SavingTimeout(JS value)
		{
			base.Options["savingTimeout"] = value;
			return this;
		}

		/// <summary>Specifies the key for storing the widget state.</summary>
		[Generated]
		public DataGridStateStoringBuilder StorageKey(string value)
		{
			base.Options["storageKey"] = value;
			return this;
		}

		/// <summary>Specifies the key for storing the widget state.</summary>
		[Generated]
		public DataGridStateStoringBuilder StorageKey(JS value)
		{
			base.Options["storageKey"] = value;
			return this;
		}

		/// <summary>Specifies the type of storage where the state is saved.</summary>
		[Generated]
		public DataGridStateStoringBuilder Type(StateStoringType value)
		{
			base.Options["type"] = value;
			return this;
		}
	}
}
