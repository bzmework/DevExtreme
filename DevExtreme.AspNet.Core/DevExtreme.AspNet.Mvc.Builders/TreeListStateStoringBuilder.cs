namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures state storing.</summary>
	public class TreeListStateStoringBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeListStateStoringBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListStateStoringBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a function that is executed on state loading. Applies only if the type is 'custom'.</summary>
		[Generated]
		public TreeListStateStoringBuilder CustomLoad(string jsFunc)
		{
			AssignJS("customLoad", jsFunc);
			return this;
		}

		/// <summary>Specifies a function that is executed on state loading. Applies only if the type is 'custom'.</summary>
		[Generated]
		public TreeListStateStoringBuilder CustomLoad(RazorBlock jsFunc)
		{
			return CustomLoad(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies a function that is executed on state saving. Applies only if the type is "custom".</summary>
		[Generated]
		public TreeListStateStoringBuilder CustomSave(string jsFunc)
		{
			AssignJS("customSave", jsFunc);
			return this;
		}

		/// <summary>Specifies a function that is executed on state saving. Applies only if the type is "custom".</summary>
		[Generated]
		public TreeListStateStoringBuilder CustomSave(RazorBlock jsFunc)
		{
			return CustomSave(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Enables state storing.</summary>
		[Generated]
		public TreeListStateStoringBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables state storing.</summary>
		[Generated]
		public TreeListStateStoringBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies the delay in milliseconds between when a user makes a change and when this change is saved.</summary>
		[Generated]
		public TreeListStateStoringBuilder SavingTimeout(double value)
		{
			base.Options["savingTimeout"] = value;
			return this;
		}

		/// <summary>Specifies the delay in milliseconds between when a user makes a change and when this change is saved.</summary>
		[Generated]
		public TreeListStateStoringBuilder SavingTimeout(JS value)
		{
			base.Options["savingTimeout"] = value;
			return this;
		}

		/// <summary>Specifies the key for storing the widget state.</summary>
		[Generated]
		public TreeListStateStoringBuilder StorageKey(string value)
		{
			base.Options["storageKey"] = value;
			return this;
		}

		/// <summary>Specifies the key for storing the widget state.</summary>
		[Generated]
		public TreeListStateStoringBuilder StorageKey(JS value)
		{
			base.Options["storageKey"] = value;
			return this;
		}

		/// <summary>Specifies the type of storage where the state is saved.</summary>
		[Generated]
		public TreeListStateStoringBuilder Type(StateStoringType value)
		{
			base.Options["type"] = value;
			return this;
		}
	}
}
