using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	public class HtmlEditorVariablesBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public HtmlEditorVariablesBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public HtmlEditorVariablesBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a collection of variables available for a user.</summary>
		[Generated]
		public HtmlEditorVariablesBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Specifies a collection of variables available for a user.</summary>
		[Generated]
		public HtmlEditorVariablesBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Specifies a collection of variables available for a user.</summary>
		[Generated]
		public HtmlEditorVariablesBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Specifies a collection of variables available for a user.</summary>
		[Generated]
		public HtmlEditorVariablesBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Specifies a collection of variables available for a user.</summary>
		[Generated]
		public HtmlEditorVariablesBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies the special character(s) that should surround the variables.</summary>
		[Generated]
		public HtmlEditorVariablesBuilder EscapeChar(IEnumerable<string> value)
		{
			base.Options["escapeChar"] = value;
			return this;
		}

		/// <summary>Specifies the special character(s) that should surround the variables.</summary>
		[Generated]
		public HtmlEditorVariablesBuilder EscapeChar(JS value)
		{
			base.Options["escapeChar"] = value;
			return this;
		}
	}
}
