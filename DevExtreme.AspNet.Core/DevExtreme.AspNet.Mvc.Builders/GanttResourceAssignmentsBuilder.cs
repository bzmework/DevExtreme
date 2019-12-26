using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures resource assignments.</summary>
	public class GanttResourceAssignmentsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public GanttResourceAssignmentsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public GanttResourceAssignmentsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Binds the widget to the data source, which contains resource assignments.</summary>
		[Generated]
		public GanttResourceAssignmentsBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to the data source, which contains resource assignments.</summary>
		[Generated]
		public GanttResourceAssignmentsBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to the data source, which contains resource assignments.</summary>
		[Generated]
		public GanttResourceAssignmentsBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to the data source, which contains resource assignments.</summary>
		[Generated]
		public GanttResourceAssignmentsBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to the data source, which contains resource assignments.</summary>
		[Generated]
		public GanttResourceAssignmentsBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies the data field that provides keys for resource assignments.</summary>
		[Generated]
		public GanttResourceAssignmentsBuilder KeyExpr(string value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides keys for resource assignments.</summary>
		[Generated]
		public GanttResourceAssignmentsBuilder KeyExpr(JS value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides resource IDs.</summary>
		[Generated]
		public GanttResourceAssignmentsBuilder ResourceIdExpr(string value)
		{
			base.Options["resourceIdExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides resource IDs.</summary>
		[Generated]
		public GanttResourceAssignmentsBuilder ResourceIdExpr(JS value)
		{
			base.Options["resourceIdExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides task IDs.</summary>
		[Generated]
		public GanttResourceAssignmentsBuilder TaskIdExpr(string value)
		{
			base.Options["taskIdExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides task IDs.</summary>
		[Generated]
		public GanttResourceAssignmentsBuilder TaskIdExpr(JS value)
		{
			base.Options["taskIdExpr"] = value;
			return this;
		}
	}
}
