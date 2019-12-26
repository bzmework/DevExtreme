namespace DevExtreme.AspNet.Mvc.Builders.DataSources
{
	public class RemoteControllerDataSourceOptionsBuilder : DataLibraryApiBuilder<RemoteControllerDataSourceOptionsBuilder>
	{
		private string _loadUrl;

		private string _insertUrl;

		private string _updateUrl;

		private string _deleteUrl;

		public RemoteControllerDataSourceOptionsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>
		/// Specifies the URL used to load data.
		/// </summary>
		/// <param name="url">A URL string.</param>
		public RemoteControllerDataSourceOptionsBuilder LoadUrl(string url)
		{
			_loadUrl = url;
			return this;
		}

		/// <summary>
		/// Specifies the URL used to insert data.
		/// </summary>
		/// <param name="url">A URL string.</param>
		public RemoteControllerDataSourceOptionsBuilder InsertUrl(string url)
		{
			_insertUrl = url;
			return this;
		}

		/// <summary>
		/// Specifies the URL used to update data.
		/// </summary>
		/// <param name="url">A URL string.</param>
		public RemoteControllerDataSourceOptionsBuilder UpdateUrl(string url)
		{
			_updateUrl = url;
			return this;
		}

		/// <summary>
		/// Specifies the URL used to delete data.
		/// </summary>
		/// <param name="url">A URL string.</param>
		public RemoteControllerDataSourceOptionsBuilder DeleteUrl(string url)
		{
			_deleteUrl = url;
			return this;
		}

		/// <summary>
		/// Specifies how data returned by <see cref="M:DevExtreme.AspNet.Mvc.Builders.DataSources.RemoteControllerDataSourceOptionsBuilder.LoadUrl(System.String)" /> is treated.
		/// </summary>
		public RemoteControllerDataSourceOptionsBuilder LoadMode(DataSourceLoadMode value)
		{
			StoreOptions["loadMode"] = value;
			return this;
		}

		/// <summary>
		/// Specifies whether raw data should be saved in the cache.
		/// Applies only if <see cref="M:DevExtreme.AspNet.Mvc.Builders.DataSources.RemoteControllerDataSourceOptionsBuilder.LoadMode(DevExtreme.AspNet.Mvc.DataSourceLoadMode)" /> is <see cref="F:DevExtreme.AspNet.Mvc.DataSourceLoadMode.Raw" />.
		/// </summary>
		public RemoteControllerDataSourceOptionsBuilder CacheRawData(bool value)
		{
			StoreOptions["cacheRawData"] = value;
			return this;
		}

		protected override string BuildLoadUrl()
		{
			return _loadUrl;
		}

		protected override string BuildInsertUrl()
		{
			return _insertUrl;
		}

		protected override string BuildUpdateUrl()
		{
			return _updateUrl;
		}

		protected override string BuildDeleteUrl()
		{
			return _deleteUrl;
		}

		/// <summary>A function that is executed before data is loaded.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnLoading(string jsFunc)
		{
			AssignStoreJS("onLoading", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before data is loaded.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnLoading(RazorBlock jsFunc)
		{
			return OnLoading(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after data is loaded.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnLoaded(string jsFunc)
		{
			AssignStoreJS("onLoaded", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after data is loaded.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnLoaded(RazorBlock jsFunc)
		{
			return OnLoaded(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is added.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnInserting(string jsFunc)
		{
			AssignStoreJS("onInserting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is added.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnInserting(RazorBlock jsFunc)
		{
			return OnInserting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is added.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnInserted(string jsFunc)
		{
			AssignStoreJS("onInserted", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is added.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnInserted(RazorBlock jsFunc)
		{
			return OnInserted(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is updated.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnUpdating(string jsFunc)
		{
			AssignStoreJS("onUpdating", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is updated.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnUpdating(RazorBlock jsFunc)
		{
			return OnUpdating(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is updated.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnUpdated(string jsFunc)
		{
			AssignStoreJS("onUpdated", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is updated.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnUpdated(RazorBlock jsFunc)
		{
			return OnUpdated(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is removed.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnRemoving(string jsFunc)
		{
			AssignStoreJS("onRemoving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is removed.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnRemoving(RazorBlock jsFunc)
		{
			return OnRemoving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is removed.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnRemoved(string jsFunc)
		{
			AssignStoreJS("onRemoved", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is removed.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnRemoved(RazorBlock jsFunc)
		{
			return OnRemoved(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is added, updated, or removed.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnModifying(string jsFunc)
		{
			AssignStoreJS("onModifying", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is added, updated, or removed.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnModifying(RazorBlock jsFunc)
		{
			return OnModifying(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is added, updated, or removed.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnModified(string jsFunc)
		{
			AssignStoreJS("onModified", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is added, updated, or removed.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnModified(RazorBlock jsFunc)
		{
			return OnModified(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before changes are pushed.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnPush(string jsFunc)
		{
			AssignStoreJS("onPush", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before changes are pushed.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder OnPush(RazorBlock jsFunc)
		{
			return OnPush(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error occurs.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder ErrorHandler(string jsFunc)
		{
			AssignStoreJS("errorHandler", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error occurs.</summary>
		[Generated]
		public RemoteControllerDataSourceOptionsBuilder ErrorHandler(RazorBlock jsFunc)
		{
			return ErrorHandler(UnwrapJavaScriptFunc(jsFunc));
		}
	}
}
