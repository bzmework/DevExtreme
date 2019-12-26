using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders.DataSources
{
	public class ControllerDataSourceOptionsBuilder : DataLibraryApiBuilder<ControllerDataSourceOptionsBuilder>
	{
		private string _routeName;

		private string _areaName;

		private string _controllerName;

		private string _loadActionName;

		private string _updateActionName;

		private string _insertActionName;

		private string _deleteActionName;

		private bool _useHttpRouting;

		private bool _areaAssigned;

		private bool? _generateLoad = true;

		private bool? _generateInsert;

		private bool? _generateUpdate;

		private bool? _generateDelete;

		public ControllerDataSourceOptionsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>
		/// Specifies the route to use.
		/// </summary>
		/// <param name="routeName">A route name.</param>
		public ControllerDataSourceOptionsBuilder RouteName(string routeName)
		{
			_routeName = routeName;
			return this;
		}

		/// <summary>
		/// Specifies access to a different area's data controller.
		/// </summary>
		/// <param name="areaName">An area name.</param>
		public ControllerDataSourceOptionsBuilder Area(string areaName)
		{
			_areaAssigned = true;
			_areaName = areaName;
			return this;
		}

		/// <summary>
		/// Specifies the data controller to access.
		/// </summary>
		/// <param name="controllerName">A controller name.</param>
		public ControllerDataSourceOptionsBuilder Controller(string controllerName)
		{
			_controllerName = controllerName;
			return this;
		}

		/// <summary>
		/// Specifies the controller action used to load data.
		/// </summary>
		/// <param name="actionName">An action name.</param>
		public ControllerDataSourceOptionsBuilder LoadAction(string actionName)
		{
			_loadActionName = actionName;
			return this;
		}

		/// <summary>
		/// Specifies the controller action used to update data.
		/// </summary>
		/// <param name="actionName">An action name.</param>
		public ControllerDataSourceOptionsBuilder UpdateAction(string actionName)
		{
			_updateActionName = actionName;
			return this;
		}

		/// <summary>
		/// Specifies the controller action used to insert data.
		/// </summary>
		/// <param name="actionName">An action name.</param>
		public ControllerDataSourceOptionsBuilder InsertAction(string actionName)
		{
			_insertActionName = actionName;
			return this;
		}

		/// <summary>
		/// Specifies the controller action used to delete data.
		/// </summary>
		/// <param name="actionName">An action name.</param>
		public ControllerDataSourceOptionsBuilder DeleteAction(string actionName)
		{
			_deleteActionName = actionName;
			return this;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ControllerDataSourceOptionsBuilder LoadAction(bool enabled)
		{
			_generateLoad = enabled;
			return this;
		}

		/// <summary>
		/// Specifies that the controller action decorated with the HttpPost attribute should be used.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ControllerDataSourceOptionsBuilder InsertAction(bool enabled)
		{
			_generateInsert = enabled;
			return this;
		}

		/// <summary>
		/// Specifies that the controller action decorated with the HttpPut attribute should be used. 
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ControllerDataSourceOptionsBuilder UpdateAction(bool enabled)
		{
			_generateUpdate = enabled;
			return this;
		}

		/// <summary>
		/// Specifies that the controller action decorated with the HttpDelete attribute should be used. 
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ControllerDataSourceOptionsBuilder DeleteAction(bool enabled)
		{
			_generateDelete = enabled;
			return this;
		}

		/// <summary>
		/// Specifies how data returned by <see cref="M:DevExtreme.AspNet.Mvc.Builders.DataSources.ControllerDataSourceOptionsBuilder.LoadAction(System.String)" /> is treated.
		/// </summary>
		public ControllerDataSourceOptionsBuilder LoadMode(DataSourceLoadMode value)
		{
			StoreOptions["loadMode"] = value;
			return this;
		}

		/// <summary>
		/// Specifies whether raw data should be saved in the cache.
		/// Applies only if <see cref="M:DevExtreme.AspNet.Mvc.Builders.DataSources.ControllerDataSourceOptionsBuilder.LoadMode(DevExtreme.AspNet.Mvc.DataSourceLoadMode)" /> is <see cref="F:DevExtreme.AspNet.Mvc.DataSourceLoadMode.Raw" />.
		/// </summary>
		public ControllerDataSourceOptionsBuilder CacheRawData(bool value)
		{
			StoreOptions["cacheRawData"] = value;
			return this;
		}

		protected override string BuildLoadUrl()
		{
			if (_generateLoad ?? true)
			{
				return GetActionUrl(_loadActionName);
			}
			return null;
		}

		protected override string BuildInsertUrl()
		{
			if (_generateInsert ?? (!string.IsNullOrEmpty(_insertActionName)))
			{
				return GetActionUrl(_insertActionName);
			}
			return null;
		}

		protected override string BuildUpdateUrl()
		{
			if (_generateUpdate ?? (!string.IsNullOrEmpty(_updateActionName)))
			{
				return GetActionUrl(_updateActionName);
			}
			return null;
		}

		protected override string BuildDeleteUrl()
		{
			if (_generateDelete ?? (!string.IsNullOrEmpty(_deleteActionName)))
			{
				return GetActionUrl(_deleteActionName);
			}
			return null;
		}

		private string GetActionUrl(string actionName)
		{
			bool useLegacyRouting = Compatibility.DataSource.UseLegacyRouting;
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			if (useLegacyRouting || !string.IsNullOrEmpty(_controllerName))
			{
				dictionary["controller"] = _controllerName;
			}
			if (useLegacyRouting || !string.IsNullOrEmpty(actionName))
			{
				dictionary["action"] = actionName;
			}
			if (_useHttpRouting)
			{
				dictionary["httproute"] = true;
			}
			if (_areaAssigned)
			{
				dictionary["area"] = _areaName;
			}
			return Portability.GetActionUrl(base.ViewContext, _routeName, dictionary);
		}

		/// <summary>A function that is executed before data is loaded.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnLoading(string jsFunc)
		{
			AssignStoreJS("onLoading", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before data is loaded.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnLoading(RazorBlock jsFunc)
		{
			return OnLoading(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after data is loaded.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnLoaded(string jsFunc)
		{
			AssignStoreJS("onLoaded", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after data is loaded.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnLoaded(RazorBlock jsFunc)
		{
			return OnLoaded(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is added.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnInserting(string jsFunc)
		{
			AssignStoreJS("onInserting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is added.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnInserting(RazorBlock jsFunc)
		{
			return OnInserting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is added.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnInserted(string jsFunc)
		{
			AssignStoreJS("onInserted", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is added.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnInserted(RazorBlock jsFunc)
		{
			return OnInserted(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is updated.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnUpdating(string jsFunc)
		{
			AssignStoreJS("onUpdating", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is updated.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnUpdating(RazorBlock jsFunc)
		{
			return OnUpdating(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is updated.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnUpdated(string jsFunc)
		{
			AssignStoreJS("onUpdated", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is updated.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnUpdated(RazorBlock jsFunc)
		{
			return OnUpdated(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is removed.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnRemoving(string jsFunc)
		{
			AssignStoreJS("onRemoving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is removed.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnRemoving(RazorBlock jsFunc)
		{
			return OnRemoving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is removed.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnRemoved(string jsFunc)
		{
			AssignStoreJS("onRemoved", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is removed.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnRemoved(RazorBlock jsFunc)
		{
			return OnRemoved(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is added, updated, or removed.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnModifying(string jsFunc)
		{
			AssignStoreJS("onModifying", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is added, updated, or removed.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnModifying(RazorBlock jsFunc)
		{
			return OnModifying(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is added, updated, or removed.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnModified(string jsFunc)
		{
			AssignStoreJS("onModified", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is added, updated, or removed.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnModified(RazorBlock jsFunc)
		{
			return OnModified(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before changes are pushed.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnPush(string jsFunc)
		{
			AssignStoreJS("onPush", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before changes are pushed.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder OnPush(RazorBlock jsFunc)
		{
			return OnPush(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error occurs.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder ErrorHandler(string jsFunc)
		{
			AssignStoreJS("errorHandler", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error occurs.</summary>
		[Generated]
		public ControllerDataSourceOptionsBuilder ErrorHandler(RazorBlock jsFunc)
		{
			return ErrorHandler(UnwrapJavaScriptFunc(jsFunc));
		}
	}
}
