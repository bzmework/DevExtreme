using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures task resources.</summary>
	public class GanttResourcesBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public GanttResourcesBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public GanttResourcesBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Binds the widget to the data source, which contains resources.</summary>
		[Generated]
		public GanttResourcesBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to the data source, which contains resources.</summary>
		[Generated]
		public GanttResourcesBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to the data source, which contains resources.</summary>
		[Generated]
		public GanttResourcesBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to the data source, which contains resources.</summary>
		[Generated]
		public GanttResourcesBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to the data source, which contains resources.</summary>
		[Generated]
		public GanttResourcesBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies the data field that provides keys for resources.</summary>
		[Generated]
		public GanttResourcesBuilder KeyExpr(string value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides keys for resources.</summary>
		[Generated]
		public GanttResourcesBuilder KeyExpr(JS value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides resource texts.</summary>
		[Generated]
		public GanttResourcesBuilder TextExpr(string value)
		{
			base.Options["textExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides resource texts.</summary>
		[Generated]
		public GanttResourcesBuilder TextExpr(JS value)
		{
			base.Options["textExpr"] = value;
			return this;
		}
	}
}
