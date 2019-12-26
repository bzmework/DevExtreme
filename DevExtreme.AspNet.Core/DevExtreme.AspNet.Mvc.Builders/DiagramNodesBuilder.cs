using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Allows you to bind the collection of diagram nodes to a data source.</summary>
	public class DiagramNodesBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DiagramNodesBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DiagramNodesBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies an auto-layout algorithm that the widget uses to build a diagram.</summary>
		[Generated]
		public DiagramNodesBuilder AutoLayout(Action<DiagramNodesAutoLayoutBuilder> configurator)
		{
			NestedOptions("autoLayout", configurator);
			return this;
		}

		/// <summary>Specifies an auto-layout algorithm that the widget uses to build a diagram.</summary>
		[Generated]
		public DiagramNodesBuilder AutoLayout(DiagramDataLayoutType value)
		{
			base.Options["autoLayout"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a container's nested items.</summary>
		[Generated]
		public DiagramNodesBuilder ChildrenExpr(string value)
		{
			base.Options["childrenExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a container's nested items.</summary>
		[Generated]
		public DiagramNodesBuilder ChildrenExpr(JS value)
		{
			base.Options["childrenExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a key of a node's parent container node.</summary>
		[Generated]
		public DiagramNodesBuilder ContainerKeyExpr(string value)
		{
			base.Options["containerKeyExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a key of a node's parent container node.</summary>
		[Generated]
		public DiagramNodesBuilder ContainerKeyExpr(JS value)
		{
			base.Options["containerKeyExpr"] = value;
			return this;
		}

		/// <summary>Binds the nodes collection to the specified data.</summary>
		[Generated]
		public DiagramNodesBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the nodes collection to the specified data.</summary>
		[Generated]
		public DiagramNodesBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the nodes collection to the specified data.</summary>
		[Generated]
		public DiagramNodesBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the nodes collection to the specified data.</summary>
		[Generated]
		public DiagramNodesBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the nodes collection to the specified data.</summary>
		[Generated]
		public DiagramNodesBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a node's height.</summary>
		[Generated]
		public DiagramNodesBuilder HeightExpr(string value)
		{
			base.Options["heightExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a node's height.</summary>
		[Generated]
		public DiagramNodesBuilder HeightExpr(JS value)
		{
			base.Options["heightExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a node image's URL.</summary>
		[Generated]
		public DiagramNodesBuilder ImageUrlExpr(string value)
		{
			base.Options["imageUrlExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a node image's URL.</summary>
		[Generated]
		public DiagramNodesBuilder ImageUrlExpr(JS value)
		{
			base.Options["imageUrlExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a node's nested items.</summary>
		[Generated]
		public DiagramNodesBuilder ItemsExpr(string value)
		{
			base.Options["itemsExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a node's nested items.</summary>
		[Generated]
		public DiagramNodesBuilder ItemsExpr(JS value)
		{
			base.Options["itemsExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides node keys.</summary>
		[Generated]
		public DiagramNodesBuilder KeyExpr(string value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides node keys.</summary>
		[Generated]
		public DiagramNodesBuilder KeyExpr(JS value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides the x-coordinate of a node's left border.</summary>
		[Generated]
		public DiagramNodesBuilder LeftExpr(string value)
		{
			base.Options["leftExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides the x-coordinate of a node's left border.</summary>
		[Generated]
		public DiagramNodesBuilder LeftExpr(JS value)
		{
			base.Options["leftExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression whose values indicate whether a node is locked.</summary>
		[Generated]
		public DiagramNodesBuilder LockedExpr(string value)
		{
			base.Options["lockedExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression whose values indicate whether a node is locked.</summary>
		[Generated]
		public DiagramNodesBuilder LockedExpr(JS value)
		{
			base.Options["lockedExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a parent node ID for a node.</summary>
		[Generated]
		public DiagramNodesBuilder ParentKeyExpr(string value)
		{
			base.Options["parentKeyExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a parent node ID for a node.</summary>
		[Generated]
		public DiagramNodesBuilder ParentKeyExpr(JS value)
		{
			base.Options["parentKeyExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a node style.</summary>
		[Generated]
		public DiagramNodesBuilder StyleExpr(string value)
		{
			base.Options["styleExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a node style.</summary>
		[Generated]
		public DiagramNodesBuilder StyleExpr(JS value)
		{
			base.Options["styleExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides node texts.</summary>
		[Generated]
		public DiagramNodesBuilder TextExpr(string value)
		{
			base.Options["textExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides node texts.</summary>
		[Generated]
		public DiagramNodesBuilder TextExpr(JS value)
		{
			base.Options["textExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a node's text style.</summary>
		[Generated]
		public DiagramNodesBuilder TextStyleExpr(string value)
		{
			base.Options["textStyleExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a node's text style.</summary>
		[Generated]
		public DiagramNodesBuilder TextStyleExpr(JS value)
		{
			base.Options["textStyleExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides the y-coordinate of a node's top border.</summary>
		[Generated]
		public DiagramNodesBuilder TopExpr(string value)
		{
			base.Options["topExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides the y-coordinate of a node's top border.</summary>
		[Generated]
		public DiagramNodesBuilder TopExpr(JS value)
		{
			base.Options["topExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides the shape type for a node.</summary>
		[Generated]
		public DiagramNodesBuilder TypeExpr(string value)
		{
			base.Options["typeExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides the shape type for a node.</summary>
		[Generated]
		public DiagramNodesBuilder TypeExpr(JS value)
		{
			base.Options["typeExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a node's width.</summary>
		[Generated]
		public DiagramNodesBuilder WidthExpr(string value)
		{
			base.Options["widthExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a node's width.</summary>
		[Generated]
		public DiagramNodesBuilder WidthExpr(JS value)
		{
			base.Options["widthExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a node's z-index.</summary>
		[Generated]
		public DiagramNodesBuilder ZIndexExpr(string value)
		{
			base.Options["zIndexExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source field or an expression that provides a node's z-index.</summary>
		[Generated]
		public DiagramNodesBuilder ZIndexExpr(JS value)
		{
			base.Options["zIndexExpr"] = value;
			return this;
		}
	}
}
