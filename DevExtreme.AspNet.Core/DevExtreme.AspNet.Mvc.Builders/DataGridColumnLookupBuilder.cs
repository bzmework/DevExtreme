using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options of a lookup column.</summary>
	public class DataGridColumnLookupBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridColumnLookupBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridColumnLookupBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether a user can nullify values of the lookup column.</summary>
		[Generated]
		public DataGridColumnLookupBuilder AllowClearing(bool value)
		{
			base.Options["allowClearing"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can nullify values of the lookup column.</summary>
		[Generated]
		public DataGridColumnLookupBuilder AllowClearing(JS value)
		{
			base.Options["allowClearing"] = value;
			return this;
		}

		/// <summary>Specifies the data source for the lookup column.</summary>
		[Generated]
		public DataGridColumnLookupBuilder DataSource(string jsFunc)
		{
			AssignJS("dataSource", jsFunc);
			return this;
		}

		/// <summary>Specifies the data source for the lookup column.</summary>
		[Generated]
		public DataGridColumnLookupBuilder DataSource(RazorBlock jsFunc)
		{
			return DataSource(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the data source for the lookup column.</summary>
		[Generated]
		public DataGridColumnLookupBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Specifies the data source for the lookup column.</summary>
		[Generated]
		public DataGridColumnLookupBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Specifies the data source for the lookup column.</summary>
		[Generated]
		public DataGridColumnLookupBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Specifies the data source for the lookup column.</summary>
		[Generated]
		public DataGridColumnLookupBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Specifies the data source for the lookup column.</summary>
		[Generated]
		public DataGridColumnLookupBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies the data source field whose values must be displayed.</summary>
		[Generated]
		public DataGridColumnLookupBuilder DisplayExpr(string value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data source field whose values must be displayed.</summary>
		[Generated]
		public DataGridColumnLookupBuilder DisplayExpr(JS value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data source field whose values must be replaced.</summary>
		[Generated]
		public DataGridColumnLookupBuilder ValueExpr(string value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data source field whose values must be replaced.</summary>
		[Generated]
		public DataGridColumnLookupBuilder ValueExpr(JS value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}
	}
}
