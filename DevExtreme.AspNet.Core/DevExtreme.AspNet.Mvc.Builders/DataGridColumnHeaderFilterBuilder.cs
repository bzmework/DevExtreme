using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies data settings for the header filter.</summary>
	public class DataGridColumnHeaderFilterBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridColumnHeaderFilterBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridColumnHeaderFilterBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether searching is enabled in the header filter.</summary>
		[Generated]
		public DataGridColumnHeaderFilterBuilder AllowSearch(bool value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies whether searching is enabled in the header filter.</summary>
		[Generated]
		public DataGridColumnHeaderFilterBuilder AllowSearch(JS value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies a data source for the header filter.</summary>
		[Generated]
		public DataGridColumnHeaderFilterBuilder DataSource(string jsFunc)
		{
			AssignJS("dataSource", jsFunc);
			return this;
		}

		/// <summary>Specifies a data source for the header filter.</summary>
		[Generated]
		public DataGridColumnHeaderFilterBuilder DataSource(RazorBlock jsFunc)
		{
			return DataSource(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies a data source for the header filter.</summary>
		[Generated]
		public DataGridColumnHeaderFilterBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Specifies a data source for the header filter.</summary>
		[Generated]
		public DataGridColumnHeaderFilterBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Specifies a data source for the header filter.</summary>
		[Generated]
		public DataGridColumnHeaderFilterBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Specifies a data source for the header filter.</summary>
		[Generated]
		public DataGridColumnHeaderFilterBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Specifies a data source for the header filter.</summary>
		[Generated]
		public DataGridColumnHeaderFilterBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies how the header filter combines values into groups.</summary>
		[Generated]
		public DataGridColumnHeaderFilterBuilder GroupInterval(HeaderFilterGroupInterval value)
		{
			base.Options["groupInterval"] = value;
			return this;
		}

		/// <summary>Specifies how the header filter combines values into groups.</summary>
		[Generated]
		public DataGridColumnHeaderFilterBuilder GroupInterval(double value)
		{
			base.Options["groupInterval"] = value;
			return this;
		}

		/// <summary>Specifies how the header filter combines values into groups.</summary>
		[Generated]
		public DataGridColumnHeaderFilterBuilder GroupInterval(JS value)
		{
			base.Options["groupInterval"] = value;
			return this;
		}

		/// <summary>Specifies the height of the popup menu containing filtering values.</summary>
		[Generated]
		public DataGridColumnHeaderFilterBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the height of the popup menu containing filtering values.</summary>
		[Generated]
		public DataGridColumnHeaderFilterBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies a comparison operation used to search header filter values.</summary>
		[Generated]
		public DataGridColumnHeaderFilterBuilder SearchMode(CollectionSearchMode value)
		{
			base.Options["searchMode"] = value;
			return this;
		}

		/// <summary>Specifies the width of the popup menu containing filtering values.</summary>
		[Generated]
		public DataGridColumnHeaderFilterBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the popup menu containing filtering values.</summary>
		[Generated]
		public DataGridColumnHeaderFilterBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
