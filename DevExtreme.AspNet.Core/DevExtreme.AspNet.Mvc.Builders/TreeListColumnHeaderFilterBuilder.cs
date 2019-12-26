using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies data settings for the header filter.</summary>
	public class TreeListColumnHeaderFilterBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeListColumnHeaderFilterBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListColumnHeaderFilterBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether searching is enabled in the header filter.</summary>
		[Generated]
		public TreeListColumnHeaderFilterBuilder AllowSearch(bool value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies whether searching is enabled in the header filter.</summary>
		[Generated]
		public TreeListColumnHeaderFilterBuilder AllowSearch(JS value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies a data source for the header filter.</summary>
		[Generated]
		public TreeListColumnHeaderFilterBuilder DataSource(string jsFunc)
		{
			AssignJS("dataSource", jsFunc);
			return this;
		}

		/// <summary>Specifies a data source for the header filter.</summary>
		[Generated]
		public TreeListColumnHeaderFilterBuilder DataSource(RazorBlock jsFunc)
		{
			return DataSource(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies a data source for the header filter.</summary>
		[Generated]
		public TreeListColumnHeaderFilterBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Specifies a data source for the header filter.</summary>
		[Generated]
		public TreeListColumnHeaderFilterBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Specifies a data source for the header filter.</summary>
		[Generated]
		public TreeListColumnHeaderFilterBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Specifies a data source for the header filter.</summary>
		[Generated]
		public TreeListColumnHeaderFilterBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Specifies a data source for the header filter.</summary>
		[Generated]
		public TreeListColumnHeaderFilterBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies how the header filter combines values into groups.</summary>
		[Generated]
		public TreeListColumnHeaderFilterBuilder GroupInterval(HeaderFilterGroupInterval value)
		{
			base.Options["groupInterval"] = value;
			return this;
		}

		/// <summary>Specifies how the header filter combines values into groups.</summary>
		[Generated]
		public TreeListColumnHeaderFilterBuilder GroupInterval(double value)
		{
			base.Options["groupInterval"] = value;
			return this;
		}

		/// <summary>Specifies how the header filter combines values into groups.</summary>
		[Generated]
		public TreeListColumnHeaderFilterBuilder GroupInterval(JS value)
		{
			base.Options["groupInterval"] = value;
			return this;
		}

		/// <summary>Specifies the height of the popup menu containing filtering values.</summary>
		[Generated]
		public TreeListColumnHeaderFilterBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the height of the popup menu containing filtering values.</summary>
		[Generated]
		public TreeListColumnHeaderFilterBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies a comparison operation used to search header filter values.</summary>
		[Generated]
		public TreeListColumnHeaderFilterBuilder SearchMode(CollectionSearchMode value)
		{
			base.Options["searchMode"] = value;
			return this;
		}

		/// <summary>Specifies the width of the popup menu containing filtering values.</summary>
		[Generated]
		public TreeListColumnHeaderFilterBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the popup menu containing filtering values.</summary>
		[Generated]
		public TreeListColumnHeaderFilterBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
