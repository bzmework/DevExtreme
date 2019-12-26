using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options of a lookup column.</summary>
	public class TreeListColumnLookupBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeListColumnLookupBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListColumnLookupBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether a user can nullify values of the lookup column.</summary>
		[Generated]
		public TreeListColumnLookupBuilder AllowClearing(bool value)
		{
			base.Options["allowClearing"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can nullify values of the lookup column.</summary>
		[Generated]
		public TreeListColumnLookupBuilder AllowClearing(JS value)
		{
			base.Options["allowClearing"] = value;
			return this;
		}

		/// <summary>Specifies the data source for the lookup column.</summary>
		[Generated]
		public TreeListColumnLookupBuilder DataSource(string jsFunc)
		{
			AssignJS("dataSource", jsFunc);
			return this;
		}

		/// <summary>Specifies the data source for the lookup column.</summary>
		[Generated]
		public TreeListColumnLookupBuilder DataSource(RazorBlock jsFunc)
		{
			return DataSource(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the data source for the lookup column.</summary>
		[Generated]
		public TreeListColumnLookupBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Specifies the data source for the lookup column.</summary>
		[Generated]
		public TreeListColumnLookupBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Specifies the data source for the lookup column.</summary>
		[Generated]
		public TreeListColumnLookupBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Specifies the data source for the lookup column.</summary>
		[Generated]
		public TreeListColumnLookupBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Specifies the data source for the lookup column.</summary>
		[Generated]
		public TreeListColumnLookupBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies the data source field whose values must be displayed.</summary>
		[Generated]
		public TreeListColumnLookupBuilder DisplayExpr(string value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data source field whose values must be displayed.</summary>
		[Generated]
		public TreeListColumnLookupBuilder DisplayExpr(JS value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data source field whose values must be replaced.</summary>
		[Generated]
		public TreeListColumnLookupBuilder ValueExpr(string value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data source field whose values must be replaced.</summary>
		[Generated]
		public TreeListColumnLookupBuilder ValueExpr(JS value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}
	}
}
