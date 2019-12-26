using Newtonsoft.Json.Linq;
using System;

namespace DevExtreme.AspNet.Mvc.Builders.DataSources
{
	public class DataSourceOptionsBuilder : OptionsOwnerBuilder
	{
		protected override bool IsMergable => true;

		/// <summary>
		/// Specifies the fields to select from data objects.
		/// </summary>
		public DataSourceOptionsBuilder Select(params string[] fieldNames)
		{
			base.Options["select"] = fieldNames;
			return this;
		}

		/// <summary>
		/// Specifies data sorting options.
		/// </summary>
		public DataSourceOptionsBuilder Sort(Action<DataSourceSortBuilder> configurator)
		{
			DataSourceSortBuilder dataSourceSortBuilder = new DataSourceSortBuilder(CreateChildContext("sort"));
			configurator(dataSourceSortBuilder);
			dataSourceSortBuilder.AttachNestedOptionsToParent(base.Options);
			return this;
		}

		/// <summary>
		/// Specifies data sorting options.
		/// </summary>
		public DataSourceOptionsBuilder Sort(string fieldName, bool desc = false)
		{
			return Sort(delegate(DataSourceSortBuilder i)
			{
				i.AddSorting(fieldName, desc);
			});
		}

		/// <summary>
		/// Specifies data filtering conditions.
		/// </summary>
		public DataSourceOptionsBuilder Filter(string jsExpr)
		{
			base.Options["filter"] = new JRaw(jsExpr);
			return this;
		}

		/// <summary>
		/// Specifies data filtering conditions.
		/// </summary>
		public DataSourceOptionsBuilder Filter(object filterExpr)
		{
			base.Options["filter"] = filterExpr;
			return this;
		}

		/// <summary>
		/// Specifies data grouping options.
		/// </summary>
		public DataSourceOptionsBuilder Group(string fieldName, bool desc = false)
		{
			base.Options["group"] = DataSourceSortBuilder.CreateSortInfo(fieldName, desc);
			return this;
		}

		/// <summary>
		/// Specifies the fields to search.
		/// </summary>
		public DataSourceOptionsBuilder SearchExpr(params string[] fieldNames)
		{
			base.Options["searchExpr"] = fieldNames;
			return this;
		}

		/// <summary>
		/// Specifies the comparison operation used in searching.
		/// </summary>
		public DataSourceOptionsBuilder SearchOperation(FilterOperations operation)
		{
			base.Options["searchOperation"] = operation;
			return this;
		}

		/// <summary>
		/// Specifies whether to reload data after receiving a push update.
		/// </summary>
		public DataSourceOptionsBuilder ReshapeOnPush(bool value)
		{
			base.Options["reshapeOnPush"] = value;
			return this;
		}

		/// <summary>
		/// Specifies the period (in milliseconds) when changes are aggregated before pushing them to the DataSource.
		/// </summary>
		public DataSourceOptionsBuilder PushAggregationTimeout(double value)
		{
			base.Options["pushAggregationTimeout"] = value;
			return this;
		}

		[Generated]
		public DataSourceOptionsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataSourceOptionsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the maximum number of items the page can contain.</summary>
		[Generated]
		public DataSourceOptionsBuilder PageSize(int value)
		{
			base.Options["pageSize"] = value;
			return this;
		}

		/// <summary>Specifies whether a DataSource loads data by pages, or all items at once.</summary>
		[Generated]
		public DataSourceOptionsBuilder Paginate(bool value)
		{
			base.Options["paginate"] = value;
			return this;
		}

		/// <summary>A handler for the loadError event.</summary>
		[Generated]
		public DataSourceOptionsBuilder OnLoadError(string jsFunc)
		{
			AssignJS("onLoadError", jsFunc);
			return this;
		}

		/// <summary>A handler for the loadError event.</summary>
		[Generated]
		public DataSourceOptionsBuilder OnLoadError(RazorBlock jsFunc)
		{
			return OnLoadError(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A handler for the loadingChanged event.</summary>
		[Generated]
		public DataSourceOptionsBuilder OnLoadingChanged(string jsFunc)
		{
			AssignJS("onLoadingChanged", jsFunc);
			return this;
		}

		/// <summary>A handler for the loadingChanged event.</summary>
		[Generated]
		public DataSourceOptionsBuilder OnLoadingChanged(RazorBlock jsFunc)
		{
			return OnLoadingChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>The item mapping function.</summary>
		[Generated]
		public DataSourceOptionsBuilder Map(string jsFunc)
		{
			AssignJS("map", jsFunc);
			return this;
		}

		/// <summary>The item mapping function.</summary>
		[Generated]
		public DataSourceOptionsBuilder Map(RazorBlock jsFunc)
		{
			return Map(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>The data post processing function.</summary>
		[Generated]
		public DataSourceOptionsBuilder PostProcess(string jsFunc)
		{
			AssignJS("postProcess", jsFunc);
			return this;
		}

		/// <summary>The data post processing function.</summary>
		[Generated]
		public DataSourceOptionsBuilder PostProcess(RazorBlock jsFunc)
		{
			return PostProcess(UnwrapJavaScriptFunc(jsFunc));
		}
	}
}
