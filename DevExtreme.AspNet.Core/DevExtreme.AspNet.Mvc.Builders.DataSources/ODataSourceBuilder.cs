using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders.DataSources
{
	public class ODataSourceBuilder : StoreDataSourceBuilder
	{
		public ODataSourceBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>
		/// Specifies the key property or properties.
		/// </summary>
		public ODataSourceBuilder Key(params string[] key)
		{
			SetKey(key);
			return this;
		}

		/// <summary>
		/// A function used to customize a web request before it is sent.
		/// </summary>
		public ODataSourceBuilder BeforeSend(string jsFunc)
		{
			StoreOptions["beforeSend"] = new JS(jsFunc);
			return this;
		}

		/// <summary>
		/// A function used to customize a web request before it is sent.
		/// </summary>
		public ODataSourceBuilder BeforeSend(RazorBlock jsFunc)
		{
			return BeforeSend(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// Specifies whether or not dates found in the response are deserialized.
		/// </summary>
		public ODataSourceBuilder DeserializeDates(bool value)
		{
			StoreOptions["deserializeDates"] = value;
			return this;
		}

		/// <summary>
		/// Specifies whether the ODataStore uses the JSONP approach to access non-CORS-compatible remote services.
		/// </summary>
		public ODataSourceBuilder JSONP(bool value)
		{
			StoreOptions["jsonp"] = value;
			return this;
		}

		/// <summary>
		/// Specifies the type of the key property or properties.
		/// </summary>
		public ODataSourceBuilder KeyType(EdmType type)
		{
			StoreOptions["keyType"] = type;
			return this;
		}

		/// <summary>
		/// Specifies the type of the key property or properties.
		/// </summary>
		public ODataSourceBuilder KeyType(IDictionary<string, EdmType> compoundKeyType)
		{
			StoreOptions["keyType"] = compoundKeyType;
			return this;
		}

		/// <summary>
		/// Specifies the types of data fields.
		/// </summary>
		public ODataSourceBuilder FieldTypes(IDictionary<string, EdmType> fieldTypes)
		{
			StoreOptions["fieldTypes"] = fieldTypes;
			return this;
		}

		/// <summary>
		/// Specifies the URL of the OData entity to access.
		/// </summary>
		public ODataSourceBuilder Url(string url)
		{
			StoreOptions["url"] = url;
			return this;
		}

		/// <summary>
		/// Specifies the version of the OData protocol used to interact with the data service.
		/// </summary>
		public ODataSourceBuilder Version(int version)
		{
			StoreOptions["version"] = version;
			return this;
		}

		/// <summary>
		/// Specifies whether to send cookies and authorization headers to foreign domains in a cross-origin request.
		/// </summary>
		public ODataSourceBuilder WithCredentials(bool value)
		{
			StoreOptions["withCredentials"] = value;
			return this;
		}

		/// <summary>
		/// Specifies the navigation properties that are loaded with the OData entity.
		/// </summary>
		public ODataSourceBuilder Expand(params string[] propertyNames)
		{
			base.Options["expand"] = propertyNames;
			return this;
		}

		protected override string FormatStoreFactory(string args)
		{
			return "new DevExpress.data.ODataStore(" + args + ")";
		}

		/// <summary>A function that is executed before data is loaded.</summary>
		[Generated]
		public ODataSourceBuilder OnLoading(string jsFunc)
		{
			AssignStoreJS("onLoading", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before data is loaded.</summary>
		[Generated]
		public ODataSourceBuilder OnLoading(RazorBlock jsFunc)
		{
			return OnLoading(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after data is loaded.</summary>
		[Generated]
		public ODataSourceBuilder OnLoaded(string jsFunc)
		{
			AssignStoreJS("onLoaded", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after data is loaded.</summary>
		[Generated]
		public ODataSourceBuilder OnLoaded(RazorBlock jsFunc)
		{
			return OnLoaded(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is added.</summary>
		[Generated]
		public ODataSourceBuilder OnInserting(string jsFunc)
		{
			AssignStoreJS("onInserting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is added.</summary>
		[Generated]
		public ODataSourceBuilder OnInserting(RazorBlock jsFunc)
		{
			return OnInserting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is added.</summary>
		[Generated]
		public ODataSourceBuilder OnInserted(string jsFunc)
		{
			AssignStoreJS("onInserted", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is added.</summary>
		[Generated]
		public ODataSourceBuilder OnInserted(RazorBlock jsFunc)
		{
			return OnInserted(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is updated.</summary>
		[Generated]
		public ODataSourceBuilder OnUpdating(string jsFunc)
		{
			AssignStoreJS("onUpdating", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is updated.</summary>
		[Generated]
		public ODataSourceBuilder OnUpdating(RazorBlock jsFunc)
		{
			return OnUpdating(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is updated.</summary>
		[Generated]
		public ODataSourceBuilder OnUpdated(string jsFunc)
		{
			AssignStoreJS("onUpdated", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is updated.</summary>
		[Generated]
		public ODataSourceBuilder OnUpdated(RazorBlock jsFunc)
		{
			return OnUpdated(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is removed.</summary>
		[Generated]
		public ODataSourceBuilder OnRemoving(string jsFunc)
		{
			AssignStoreJS("onRemoving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is removed.</summary>
		[Generated]
		public ODataSourceBuilder OnRemoving(RazorBlock jsFunc)
		{
			return OnRemoving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is removed.</summary>
		[Generated]
		public ODataSourceBuilder OnRemoved(string jsFunc)
		{
			AssignStoreJS("onRemoved", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is removed.</summary>
		[Generated]
		public ODataSourceBuilder OnRemoved(RazorBlock jsFunc)
		{
			return OnRemoved(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is added, updated, or removed.</summary>
		[Generated]
		public ODataSourceBuilder OnModifying(string jsFunc)
		{
			AssignStoreJS("onModifying", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is added, updated, or removed.</summary>
		[Generated]
		public ODataSourceBuilder OnModifying(RazorBlock jsFunc)
		{
			return OnModifying(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is added, updated, or removed.</summary>
		[Generated]
		public ODataSourceBuilder OnModified(string jsFunc)
		{
			AssignStoreJS("onModified", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is added, updated, or removed.</summary>
		[Generated]
		public ODataSourceBuilder OnModified(RazorBlock jsFunc)
		{
			return OnModified(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before changes are pushed.</summary>
		[Generated]
		public ODataSourceBuilder OnPush(string jsFunc)
		{
			AssignStoreJS("onPush", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before changes are pushed.</summary>
		[Generated]
		public ODataSourceBuilder OnPush(RazorBlock jsFunc)
		{
			return OnPush(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error occurs.</summary>
		[Generated]
		public ODataSourceBuilder ErrorHandler(string jsFunc)
		{
			AssignStoreJS("errorHandler", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error occurs.</summary>
		[Generated]
		public ODataSourceBuilder ErrorHandler(RazorBlock jsFunc)
		{
			return ErrorHandler(UnwrapJavaScriptFunc(jsFunc));
		}
	}
}
