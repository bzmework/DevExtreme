namespace DevExtreme.AspNet.Mvc.Builders.DataSources
{
	public class XmlaDataSourceBuilder : StoreDataSourceBuilder
	{
		public XmlaDataSourceBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>
		/// Specifies the database that contains the OLAP cube to use.
		/// </summary>
		public XmlaDataSourceBuilder Url(string url)
		{
			StoreOptions["url"] = url;
			return this;
		}

		/// <summary>
		/// Specifies the database that contains the OLAP cube to use.
		/// </summary>
		public XmlaDataSourceBuilder Catalog(string catalog)
		{
			StoreOptions["catalog"] = catalog;
			return this;
		}

		/// <summary>
		/// Specifies the name of the OLAP cube to use from the catalog.
		/// </summary>
		public XmlaDataSourceBuilder Cube(string cube)
		{
			StoreOptions["cube"] = cube;
			return this;
		}

		/// <summary>
		/// Specifies a function used to customize a web request before it is sent.
		/// </summary>
		public XmlaDataSourceBuilder BeforeSend(string jsFunc)
		{
			StoreOptions["beforeSend"] = new JS(jsFunc);
			return this;
		}

		/// <summary>
		/// Specifies a function used to customize a web request before it is sent.
		/// </summary>
		public XmlaDataSourceBuilder BeforeSend(RazorBlock jsFunc)
		{
			return BeforeSend(UnwrapJavaScriptFunc(jsFunc));
		}

		protected override string FormatStoreFactory(string args)
		{
			return "new DevExpress.data.XmlaStore(" + args + ")";
		}
	}
}
