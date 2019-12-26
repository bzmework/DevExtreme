using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Allows you to bind the collection of diagram edges to a data source.</summary>
	public class DiagramEdgesBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DiagramEdgesBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DiagramEdgesBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Binds the edges collection to the specified data.</summary>
		[Generated]
		public DiagramEdgesBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the edges collection to the specified data.</summary>
		[Generated]
		public DiagramEdgesBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the edges collection to the specified data.</summary>
		[Generated]
		public DiagramEdgesBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the edges collection to the specified data.</summary>
		[Generated]
		public DiagramEdgesBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the edges collection to the specified data.</summary>
		[Generated]
		public DiagramEdgesBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an edge's start node key.</summary>
		[Generated]
		public DiagramEdgesBuilder FromExpr(string value)
		{
			base.Options["fromExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an edge's start node key.</summary>
		[Generated]
		public DiagramEdgesBuilder FromExpr(JS value)
		{
			base.Options["fromExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an edge's line start tip.</summary>
		[Generated]
		public DiagramEdgesBuilder FromLineEndExpr(string value)
		{
			base.Options["fromLineEndExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an edge's line start tip.</summary>
		[Generated]
		public DiagramEdgesBuilder FromLineEndExpr(JS value)
		{
			base.Options["fromLineEndExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an index of a shape connection point where an edge starts.</summary>
		[Generated]
		public DiagramEdgesBuilder FromPointIndexExpr(string value)
		{
			base.Options["fromPointIndexExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an index of a shape connection point where an edge starts.</summary>
		[Generated]
		public DiagramEdgesBuilder FromPointIndexExpr(JS value)
		{
			base.Options["fromPointIndexExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides edge keys.</summary>
		[Generated]
		public DiagramEdgesBuilder KeyExpr(string value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides edge keys.</summary>
		[Generated]
		public DiagramEdgesBuilder KeyExpr(JS value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an edge's line type.</summary>
		[Generated]
		public DiagramEdgesBuilder LineTypeExpr(string value)
		{
			base.Options["lineTypeExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an edge's line type.</summary>
		[Generated]
		public DiagramEdgesBuilder LineTypeExpr(JS value)
		{
			base.Options["lineTypeExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression whose values indicate whether an edge is locked.</summary>
		[Generated]
		public DiagramEdgesBuilder LockedExpr(string value)
		{
			base.Options["lockedExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression whose values indicate whether an edge is locked.</summary>
		[Generated]
		public DiagramEdgesBuilder LockedExpr(JS value)
		{
			base.Options["lockedExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an edge's key points.</summary>
		[Generated]
		public DiagramEdgesBuilder PointsExpr(string value)
		{
			base.Options["pointsExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an edge's key points.</summary>
		[Generated]
		public DiagramEdgesBuilder PointsExpr(JS value)
		{
			base.Options["pointsExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an edge style.</summary>
		[Generated]
		public DiagramEdgesBuilder StyleExpr(string value)
		{
			base.Options["styleExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an edge style.</summary>
		[Generated]
		public DiagramEdgesBuilder StyleExpr(JS value)
		{
			base.Options["styleExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides edge texts.</summary>
		[Generated]
		public DiagramEdgesBuilder TextExpr(string value)
		{
			base.Options["textExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides edge texts.</summary>
		[Generated]
		public DiagramEdgesBuilder TextExpr(JS value)
		{
			base.Options["textExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an edge's text style.</summary>
		[Generated]
		public DiagramEdgesBuilder TextStyleExpr(string value)
		{
			base.Options["textStyleExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an edge's text style.</summary>
		[Generated]
		public DiagramEdgesBuilder TextStyleExpr(JS value)
		{
			base.Options["textStyleExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an edge's end node key.</summary>
		[Generated]
		public DiagramEdgesBuilder ToExpr(string value)
		{
			base.Options["toExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an edge's end node key.</summary>
		[Generated]
		public DiagramEdgesBuilder ToExpr(JS value)
		{
			base.Options["toExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an edge's line end tip.</summary>
		[Generated]
		public DiagramEdgesBuilder ToLineEndExpr(string value)
		{
			base.Options["toLineEndExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an edge's line end tip.</summary>
		[Generated]
		public DiagramEdgesBuilder ToLineEndExpr(JS value)
		{
			base.Options["toLineEndExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an index of a shape connection point where an edge ends.</summary>
		[Generated]
		public DiagramEdgesBuilder ToPointIndexExpr(string value)
		{
			base.Options["toPointIndexExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an index of a shape connection point where an edge ends.</summary>
		[Generated]
		public DiagramEdgesBuilder ToPointIndexExpr(JS value)
		{
			base.Options["toPointIndexExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an edge's z-index.</summary>
		[Generated]
		public DiagramEdgesBuilder ZIndexExpr(string value)
		{
			base.Options["zIndexExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides an edge's z-index.</summary>
		[Generated]
		public DiagramEdgesBuilder ZIndexExpr(JS value)
		{
			base.Options["zIndexExpr"] = value;
			return this;
		}
	}
}
