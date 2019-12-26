using System.Collections;

namespace DevExtreme.AspNet.Mvc.Builders.DataSources
{
	public class ArrayDataSourceBuilder : StoreDataSourceBuilder
	{
		public ArrayDataSourceBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>
		/// Specifies the key property or properties.
		/// </summary>
		/// <param name="key">A key property or properties.</param>
		public ArrayDataSourceBuilder Key(params string[] key)
		{
			SetKey(key);
			return this;
		}

		/// <summary>
		/// Specifies the array associated with the Store.
		/// </summary>
		/// <param name="data">An array.</param>
		public ArrayDataSourceBuilder Data(IEnumerable data)
		{
			StoreOptions["data"] = data;
			return this;
		}

		/// <summary>
		/// Specifies the array associated with the Store.
		/// </summary>
		public ArrayDataSourceBuilder Data(JS data)
		{
			StoreOptions["data"] = data;
			return this;
		}

		protected override string FormatStoreFactory(string args)
		{
			return "new DevExpress.data.ArrayStore(" + args + ")";
		}

		/// <summary>A function that is executed before data is loaded.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnLoading(string jsFunc)
		{
			AssignStoreJS("onLoading", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before data is loaded.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnLoading(RazorBlock jsFunc)
		{
			return OnLoading(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after data is loaded.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnLoaded(string jsFunc)
		{
			AssignStoreJS("onLoaded", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after data is loaded.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnLoaded(RazorBlock jsFunc)
		{
			return OnLoaded(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is added.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnInserting(string jsFunc)
		{
			AssignStoreJS("onInserting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is added.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnInserting(RazorBlock jsFunc)
		{
			return OnInserting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is added.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnInserted(string jsFunc)
		{
			AssignStoreJS("onInserted", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is added.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnInserted(RazorBlock jsFunc)
		{
			return OnInserted(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is updated.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnUpdating(string jsFunc)
		{
			AssignStoreJS("onUpdating", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is updated.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnUpdating(RazorBlock jsFunc)
		{
			return OnUpdating(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is updated.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnUpdated(string jsFunc)
		{
			AssignStoreJS("onUpdated", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is updated.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnUpdated(RazorBlock jsFunc)
		{
			return OnUpdated(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is removed.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnRemoving(string jsFunc)
		{
			AssignStoreJS("onRemoving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is removed.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnRemoving(RazorBlock jsFunc)
		{
			return OnRemoving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is removed.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnRemoved(string jsFunc)
		{
			AssignStoreJS("onRemoved", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is removed.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnRemoved(RazorBlock jsFunc)
		{
			return OnRemoved(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a data item is added, updated, or removed.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnModifying(string jsFunc)
		{
			AssignStoreJS("onModifying", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a data item is added, updated, or removed.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnModifying(RazorBlock jsFunc)
		{
			return OnModifying(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a data item is added, updated, or removed.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnModified(string jsFunc)
		{
			AssignStoreJS("onModified", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a data item is added, updated, or removed.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnModified(RazorBlock jsFunc)
		{
			return OnModified(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before changes are pushed.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnPush(string jsFunc)
		{
			AssignStoreJS("onPush", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before changes are pushed.</summary>
		[Generated]
		public ArrayDataSourceBuilder OnPush(RazorBlock jsFunc)
		{
			return OnPush(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error occurs.</summary>
		[Generated]
		public ArrayDataSourceBuilder ErrorHandler(string jsFunc)
		{
			AssignStoreJS("errorHandler", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error occurs.</summary>
		[Generated]
		public ArrayDataSourceBuilder ErrorHandler(RazorBlock jsFunc)
		{
			return ErrorHandler(UnwrapJavaScriptFunc(jsFunc));
		}
	}
}
