using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures dependencies.</summary>
	public class GanttDependenciesBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public GanttDependenciesBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public GanttDependenciesBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Binds the widget to the data source which contains dependencies.</summary>
		[Generated]
		public GanttDependenciesBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to the data source which contains dependencies.</summary>
		[Generated]
		public GanttDependenciesBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to the data source which contains dependencies.</summary>
		[Generated]
		public GanttDependenciesBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to the data source which contains dependencies.</summary>
		[Generated]
		public GanttDependenciesBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to the data source which contains dependencies.</summary>
		[Generated]
		public GanttDependenciesBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies the data field that provides keys for dependencies.</summary>
		[Generated]
		public GanttDependenciesBuilder KeyExpr(string value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides keys for dependencies.</summary>
		[Generated]
		public GanttDependenciesBuilder KeyExpr(JS value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides predecessor IDs.</summary>
		[Generated]
		public GanttDependenciesBuilder PredecessorIdExpr(string value)
		{
			base.Options["predecessorIdExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides predecessor IDs.</summary>
		[Generated]
		public GanttDependenciesBuilder PredecessorIdExpr(JS value)
		{
			base.Options["predecessorIdExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides successor IDs.</summary>
		[Generated]
		public GanttDependenciesBuilder SuccessorIdExpr(string value)
		{
			base.Options["successorIdExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides successor IDs.</summary>
		[Generated]
		public GanttDependenciesBuilder SuccessorIdExpr(JS value)
		{
			base.Options["successorIdExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides dependency types.</summary>
		[Generated]
		public GanttDependenciesBuilder TypeExpr(string value)
		{
			base.Options["typeExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides dependency types.</summary>
		[Generated]
		public GanttDependenciesBuilder TypeExpr(JS value)
		{
			base.Options["typeExpr"] = value;
			return this;
		}
	}
}
