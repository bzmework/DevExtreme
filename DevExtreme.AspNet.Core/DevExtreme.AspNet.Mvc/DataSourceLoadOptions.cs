using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Mvc;

namespace DevExtreme.AspNet.Mvc
{
	[ModelBinder(BinderType = typeof(DataSourceLoadOptionsBinder))]
	public class DataSourceLoadOptions : DataSourceLoadOptionsBase
	{
		public DataSourceLoadOptions()
			//: this()
		{
		}
	}
}
