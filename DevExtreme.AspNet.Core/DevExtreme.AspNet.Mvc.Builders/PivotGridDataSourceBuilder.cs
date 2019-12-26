using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using Newtonsoft.Json.Linq;
using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The PivotGridDataSource is an object that provides an API for processing data from an underlying store. This object is used in the PivotGrid widget.</summary>
	public class PivotGridDataSourceBuilder<T> : OptionsOwnerBuilder
	{
		[Generated]
		public PivotGridDataSourceBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PivotGridDataSourceBuilder<T> Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures pivot grid fields.</summary>
		[Generated]
		public PivotGridDataSourceBuilder<T> Fields(Action<CollectionFactory<PivotGridDataSourceFieldBuilder<T>>> configurator)
		{
			Collection("fields", configurator);
			return this;
		}

		/// <summary>Specifies data filtering conditions. Cannot be used with an XmlaStore.</summary>
		[Generated]
		public PivotGridDataSourceBuilder<T> Filter(string jsExpr)
		{
			AssignJS("filter", jsExpr);
			return this;
		}

		/// <summary>Specifies data filtering conditions. Cannot be used with an XmlaStore.</summary>
		[Generated]
		public PivotGridDataSourceBuilder<T> Filter(object filterExpr)
		{
			base.Options["filter"] = filterExpr;
			return this;
		}

		/// <summary>A function that is executed after data is successfully loaded.</summary>
		[Generated]
		public PivotGridDataSourceBuilder<T> OnChanged(string jsFunc)
		{
			AssignJS("onChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after data is successfully loaded.</summary>
		[Generated]
		public PivotGridDataSourceBuilder<T> OnChanged(RazorBlock jsFunc)
		{
			return OnChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when all fields are loaded from the store and they are ready to be displayed in the PivotGrid.</summary>
		[Generated]
		public PivotGridDataSourceBuilder<T> OnFieldsPrepared(string jsFunc)
		{
			AssignJS("onFieldsPrepared", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when all fields are loaded from the store and they are ready to be displayed in the PivotGrid.</summary>
		[Generated]
		public PivotGridDataSourceBuilder<T> OnFieldsPrepared(RazorBlock jsFunc)
		{
			return OnFieldsPrepared(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when data loading fails.</summary>
		[Generated]
		public PivotGridDataSourceBuilder<T> OnLoadError(string jsFunc)
		{
			AssignJS("onLoadError", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when data loading fails.</summary>
		[Generated]
		public PivotGridDataSourceBuilder<T> OnLoadError(RazorBlock jsFunc)
		{
			return OnLoadError(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the data loading status changes.</summary>
		[Generated]
		public PivotGridDataSourceBuilder<T> OnLoadingChanged(string jsFunc)
		{
			AssignJS("onLoadingChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the data loading status changes.</summary>
		[Generated]
		public PivotGridDataSourceBuilder<T> OnLoadingChanged(RazorBlock jsFunc)
		{
			return OnLoadingChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether the PivotGridDataSource should load data in portions. Can be used only with an XmlaStore.</summary>
		[Generated]
		public PivotGridDataSourceBuilder<T> Paginate(bool value)
		{
			base.Options["paginate"] = value;
			return this;
		}

		/// <summary>Specifies whether the PivotGridDataSource should load data in portions. Can be used only with an XmlaStore.</summary>
		[Generated]
		public PivotGridDataSourceBuilder<T> Paginate(JS value)
		{
			base.Options["paginate"] = value;
			return this;
		}

		/// <summary>Specifies whether the data processing operations (filtering, grouping, summary calculation) should be performed on the server.</summary>
		[Generated]
		public PivotGridDataSourceBuilder<T> RemoteOperations(bool value)
		{
			base.Options["remoteOperations"] = value;
			return this;
		}

		/// <summary>Specifies whether the data processing operations (filtering, grouping, summary calculation) should be performed on the server.</summary>
		[Generated]
		public PivotGridDataSourceBuilder<T> RemoteOperations(JS value)
		{
			base.Options["remoteOperations"] = value;
			return this;
		}

		/// <summary>Specifies whether to auto-generate pivot grid fields from the store's data.</summary>
		[Generated]
		public PivotGridDataSourceBuilder<T> RetrieveFields(bool value)
		{
			base.Options["retrieveFields"] = value;
			return this;
		}

		/// <summary>Specifies whether to auto-generate pivot grid fields from the store's data.</summary>
		[Generated]
		public PivotGridDataSourceBuilder<T> RetrieveFields(JS value)
		{
			base.Options["retrieveFields"] = value;
			return this;
		}

		public PivotGridDataSourceBuilder<T> Store(Func<PivotGridStoreFactory, StoreDataSourceBuilder> configurator)
		{
			PivotGridStoreFactory arg = new PivotGridStoreFactory(CreateChildContext("store"));
			StoreDataSourceBuilder storeDataSourceBuilder = configurator(arg);
			base.Options["store"] = new JRaw(storeDataSourceBuilder.GetStoreDefinition());
			return this;
		}

		public PivotGridDataSourceBuilder<T> Store(JS js)
		{
			base.Options["store"] = js;
			return this;
		}
	}
}
