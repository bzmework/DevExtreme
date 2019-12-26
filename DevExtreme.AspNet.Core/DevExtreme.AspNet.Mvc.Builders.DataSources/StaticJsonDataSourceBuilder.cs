using Newtonsoft.Json.Linq;

namespace DevExtreme.AspNet.Mvc.Builders.DataSources
{
	public class StaticJsonDataSourceBuilder : StoreDataSourceBuilder
	{
		public StaticJsonDataSourceBuilder(OptionsOwnerContext context)
			: base(context)
		{
			StoreOptions["loadMode"] = "raw";
		}

		/// <summary>
		/// Specifies the key property or properties.
		/// </summary>
		/// <param name="key">A key property or properties.</param>
		public StaticJsonDataSourceBuilder Key(params string[] key)
		{
			SetKey(key);
			return this;
		}

		/// <summary>
		/// Specifies the URL used to load JSON data.
		/// </summary>
		/// <param name="url">A URL string.</param>
		public StaticJsonDataSourceBuilder Url(string url)
		{
			url = Portability.GetContentUrl(base.ViewContext, url);
			StoreOptions["load"] = new JRaw("function() { return $.getJSON(" + JsonUtils.SafeSerialize(url) + "); }");
			return this;
		}

		/// <summary>
		/// Specifies whether to cache loaded JSON data.
		/// </summary>
		/// <param name="enabled">A flag specifying whether data caching is enabled.</param>
		public StaticJsonDataSourceBuilder CacheAllData(bool enabled)
		{
			StoreOptions["cacheRawData"] = enabled;
			return this;
		}

		protected override string FormatStoreFactory(string args)
		{
			return "new DevExpress.data.CustomStore(" + args + ")";
		}

		/// <summary>A function that is executed before data is loaded.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnLoading(string jsFunc)
		{
			AssignStoreJS("onLoading", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before data is loaded.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnLoading(RazorBlock jsFunc)
		{
			return OnLoading(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after data is loaded.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnLoaded(string jsFunc)
		{
			AssignStoreJS("onLoaded", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after data is loaded.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnLoaded(RazorBlock jsFunc)
		{
			return OnLoaded(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is added.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnInserting(string jsFunc)
		{
			AssignStoreJS("onInserting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is added.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnInserting(RazorBlock jsFunc)
		{
			return OnInserting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is added.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnInserted(string jsFunc)
		{
			AssignStoreJS("onInserted", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is added.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnInserted(RazorBlock jsFunc)
		{
			return OnInserted(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is updated.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnUpdating(string jsFunc)
		{
			AssignStoreJS("onUpdating", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is updated.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnUpdating(RazorBlock jsFunc)
		{
			return OnUpdating(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is updated.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnUpdated(string jsFunc)
		{
			AssignStoreJS("onUpdated", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is updated.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnUpdated(RazorBlock jsFunc)
		{
			return OnUpdated(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is removed.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnRemoving(string jsFunc)
		{
			AssignStoreJS("onRemoving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is removed.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnRemoving(RazorBlock jsFunc)
		{
			return OnRemoving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is removed.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnRemoved(string jsFunc)
		{
			AssignStoreJS("onRemoved", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is removed.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnRemoved(RazorBlock jsFunc)
		{
			return OnRemoved(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is added, updated, or removed.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnModifying(string jsFunc)
		{
			AssignStoreJS("onModifying", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is added, updated, or removed.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnModifying(RazorBlock jsFunc)
		{
			return OnModifying(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is added, updated, or removed.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnModified(string jsFunc)
		{
			AssignStoreJS("onModified", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is added, updated, or removed.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnModified(RazorBlock jsFunc)
		{
			return OnModified(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before changes are pushed.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnPush(string jsFunc)
		{
			AssignStoreJS("onPush", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before changes are pushed.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder OnPush(RazorBlock jsFunc)
		{
			return OnPush(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error occurs.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder ErrorHandler(string jsFunc)
		{
			AssignStoreJS("errorHandler", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error occurs.</summary>
		[Generated]
		public StaticJsonDataSourceBuilder ErrorHandler(RazorBlock jsFunc)
		{
			return ErrorHandler(UnwrapJavaScriptFunc(jsFunc));
		}
	}
}
