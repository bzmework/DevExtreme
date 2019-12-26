using System.Collections;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// 数组文件提供器
	/// </summary>
	public class ArrayFileProviderBuilder : FileProviderBuilder
	{
		protected override string ClientFileProviderName => "DevExpress.fileProviders.ArrayFileProvider";

		public ArrayFileProviderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		public ArrayFileProviderBuilder Data(IEnumerable data)
		{
			base.StoreOptions["data"] = data;
			return this;
		}

		public ArrayFileProviderBuilder Data(JS data)
		{
			base.StoreOptions["data"] = data;
			return this;
		}
	}
}
