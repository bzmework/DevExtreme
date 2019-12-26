using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.Helpers;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtreme.AspNet.Mvc
{
	public class DataSourceLoadOptionsBinder : IModelBinder
	{
		public Task BindModelAsync(ModelBindingContext bindingContext)
		{
			DataSourceLoadOptions dataSourceLoadOptions = new DataSourceLoadOptions();
			DataSourceLoadOptionsParser.Parse((DataSourceLoadOptionsBase)(object)dataSourceLoadOptions, (Func<string, string>)((string key) => bindingContext.ValueProvider.GetValue(key).FirstOrDefault()));
			bindingContext.Result = ModelBindingResult.Success(dataSourceLoadOptions);
			return Task.FromResult(result: true);
		}
	}
}
