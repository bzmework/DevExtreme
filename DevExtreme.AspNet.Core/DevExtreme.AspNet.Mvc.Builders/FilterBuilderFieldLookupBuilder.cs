using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the lookup field.</summary>
	public class FilterBuilderFieldLookupBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FilterBuilderFieldLookupBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FilterBuilderFieldLookupBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether a user can nullify the lookup values. Set to true only if your data source accepts null values.</summary>
		[Generated]
		public FilterBuilderFieldLookupBuilder AllowClearing(bool value)
		{
			base.Options["allowClearing"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can nullify the lookup values. Set to true only if your data source accepts null values.</summary>
		[Generated]
		public FilterBuilderFieldLookupBuilder AllowClearing(JS value)
		{
			base.Options["allowClearing"] = value;
			return this;
		}

		/// <summary>Specifies the lookup data source.</summary>
		[Generated]
		public FilterBuilderFieldLookupBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Specifies the lookup data source.</summary>
		[Generated]
		public FilterBuilderFieldLookupBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Specifies the lookup data source.</summary>
		[Generated]
		public FilterBuilderFieldLookupBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Specifies the lookup data source.</summary>
		[Generated]
		public FilterBuilderFieldLookupBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Specifies the lookup data source.</summary>
		[Generated]
		public FilterBuilderFieldLookupBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed.</summary>
		[Generated]
		public FilterBuilderFieldLookupBuilder DisplayExpr(string value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed.</summary>
		[Generated]
		public FilterBuilderFieldLookupBuilder DisplayExpr(JS value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data source field whose values should be replaced.</summary>
		[Generated]
		public FilterBuilderFieldLookupBuilder ValueExpr(string value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data source field whose values should be replaced.</summary>
		[Generated]
		public FilterBuilderFieldLookupBuilder ValueExpr(JS value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}
	}
}
