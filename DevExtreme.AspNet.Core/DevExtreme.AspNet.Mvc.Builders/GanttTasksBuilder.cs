using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures tasks.</summary>
	public class GanttTasksBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public GanttTasksBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public GanttTasksBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Binds the widget to the data source which contains tasks.</summary>
		[Generated]
		public GanttTasksBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to the data source which contains tasks.</summary>
		[Generated]
		public GanttTasksBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to the data source which contains tasks.</summary>
		[Generated]
		public GanttTasksBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to the data source which contains tasks.</summary>
		[Generated]
		public GanttTasksBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to the data source which contains tasks.</summary>
		[Generated]
		public GanttTasksBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies the data field that provides tasks' end dates.</summary>
		[Generated]
		public GanttTasksBuilder EndExpr(string value)
		{
			base.Options["endExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides tasks' end dates.</summary>
		[Generated]
		public GanttTasksBuilder EndExpr(JS value)
		{
			base.Options["endExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides keys for tasks.</summary>
		[Generated]
		public GanttTasksBuilder KeyExpr(string value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides keys for tasks.</summary>
		[Generated]
		public GanttTasksBuilder KeyExpr(JS value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides tasks' parent IDs.</summary>
		[Generated]
		public GanttTasksBuilder ParentIdExpr(string value)
		{
			base.Options["parentIdExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides tasks' parent IDs.</summary>
		[Generated]
		public GanttTasksBuilder ParentIdExpr(JS value)
		{
			base.Options["parentIdExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides tasks' progress.</summary>
		[Generated]
		public GanttTasksBuilder ProgressExpr(string value)
		{
			base.Options["progressExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides tasks' progress.</summary>
		[Generated]
		public GanttTasksBuilder ProgressExpr(JS value)
		{
			base.Options["progressExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides tasks' start dates.</summary>
		[Generated]
		public GanttTasksBuilder StartExpr(string value)
		{
			base.Options["startExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides tasks' start dates.</summary>
		[Generated]
		public GanttTasksBuilder StartExpr(JS value)
		{
			base.Options["startExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides task titles.</summary>
		[Generated]
		public GanttTasksBuilder TitleExpr(string value)
		{
			base.Options["titleExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides task titles.</summary>
		[Generated]
		public GanttTasksBuilder TitleExpr(JS value)
		{
			base.Options["titleExpr"] = value;
			return this;
		}
	}
}
