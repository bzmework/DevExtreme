using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders.DataSources
{
	public abstract class StoreDataSourceBuilder : OptionsOwnerBuilder
	{
		protected IDictionary<string, object> StoreOptions = new Dictionary<string, object>();

		protected override bool IsMergable => true;

		public StoreDataSourceBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		protected abstract string FormatStoreFactory(string args);

		protected internal void SetKey(params string[] key)
		{
			if (key != null && key.Length >= 1)
			{
				if (key.Length < 2)
				{
					StoreOptions["key"] = key[0];
				}
				else
				{
					StoreOptions["key"] = key;
				}
			}
		}

		protected internal string GetStoreDefinition()
		{
			CustomizeStoreOptions();
			return FormatStoreFactory(JsonUtils.SafeSerialize(StoreOptions));
		}

		protected virtual void CustomizeStoreOptions()
		{
		}

		protected internal override void AttachNestedOptionsToParent(IDictionary<string, object> parentOptions)
		{
			base.Options["store"] = new JRaw(GetStoreDefinition());
			base.AttachNestedOptionsToParent(parentOptions);
		}

		protected void AssignStoreJS(string name, string code)
		{
			if (name != null)
			{
				StoreOptions[name] = new JS(code);
			}
		}
	}
}
