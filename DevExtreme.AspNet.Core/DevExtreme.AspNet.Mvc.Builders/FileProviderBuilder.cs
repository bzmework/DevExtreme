using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	public abstract class FileProviderBuilder : OptionsOwnerBuilder
	{
		protected abstract string ClientFileProviderName
		{
			get;
		}

		protected IDictionary<string, object> StoreOptions
		{
			get;
		}

		protected override bool IsMergable => true;

		public FileProviderBuilder(OptionsOwnerContext context)
			: base(context)
		{
			StoreOptions = new Dictionary<string, object>();
		}

		protected internal override void AttachNestedOptionsToParent(IDictionary<string, object> parentOptions)
		{
			parentOptions["fileProvider"] = new JRaw(GetFileProviderDefinition());
		}

		protected internal string GetFileProviderDefinition()
		{
			return "new " + ClientFileProviderName + "(" + JsonUtils.SafeSerialize(StoreOptions) + ")";
		}
	}
}
