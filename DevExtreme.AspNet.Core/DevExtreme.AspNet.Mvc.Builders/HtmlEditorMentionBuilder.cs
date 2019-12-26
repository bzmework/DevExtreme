using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	public class HtmlEditorMentionBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public HtmlEditorMentionBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public HtmlEditorMentionBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Provides data for the suggestion list.</summary>
		[Generated]
		public HtmlEditorMentionBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Provides data for the suggestion list.</summary>
		[Generated]
		public HtmlEditorMentionBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Provides data for the suggestion list.</summary>
		[Generated]
		public HtmlEditorMentionBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Provides data for the suggestion list.</summary>
		[Generated]
		public HtmlEditorMentionBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Provides data for the suggestion list.</summary>
		[Generated]
		public HtmlEditorMentionBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed in the suggestion list.</summary>
		[Generated]
		public HtmlEditorMentionBuilder DisplayExpr(string value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed in the suggestion list.</summary>
		[Generated]
		public HtmlEditorMentionBuilder DisplayExpr(JS value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for suggestion list items.</summary>
		[Generated]
		public HtmlEditorMentionBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for suggestion list items.</summary>
		[Generated]
		public HtmlEditorMentionBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for suggestion list items.</summary>
		[Generated]
		public HtmlEditorMentionBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for suggestion list items.</summary>
		[Generated]
		public HtmlEditorMentionBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the prefix that a user enters to activate mentions. You can use different prefixes with different dataSources.</summary>
		[Generated]
		public HtmlEditorMentionBuilder Marker(string value)
		{
			base.Options["marker"] = value;
			return this;
		}

		/// <summary>Specifies the prefix that a user enters to activate mentions. You can use different prefixes with different dataSources.</summary>
		[Generated]
		public HtmlEditorMentionBuilder Marker(JS value)
		{
			base.Options["marker"] = value;
			return this;
		}

		/// <summary>Specifies the minimum number of characters that a user should type to trigger the search.</summary>
		[Generated]
		public HtmlEditorMentionBuilder MinSearchLength(int value)
		{
			base.Options["minSearchLength"] = value;
			return this;
		}

		/// <summary>Specifies the minimum number of characters that a user should type to trigger the search.</summary>
		[Generated]
		public HtmlEditorMentionBuilder MinSearchLength(JS value)
		{
			base.Options["minSearchLength"] = value;
			return this;
		}

		/// <summary>Specifies one or several data fields to search.</summary>
		[Generated]
		public HtmlEditorMentionBuilder SearchExpr(params string[] values)
		{
			base.Options["searchExpr"] = values;
			return this;
		}

		/// <summary>Specifies one or several data fields to search.</summary>
		[Generated]
		public HtmlEditorMentionBuilder SearchExpr(IEnumerable<string> value)
		{
			base.Options["searchExpr"] = value;
			return this;
		}

		/// <summary>Specifies one or several data fields to search.</summary>
		[Generated]
		public HtmlEditorMentionBuilder SearchExpr(JS value)
		{
			base.Options["searchExpr"] = value;
			return this;
		}

		/// <summary>Specifies the delay between when a user stops typing and when the search is executed.</summary>
		[Generated]
		public HtmlEditorMentionBuilder SearchTimeout(double value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies the delay between when a user stops typing and when the search is executed.</summary>
		[Generated]
		public HtmlEditorMentionBuilder SearchTimeout(JS value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for mentions.</summary>
		[Generated]
		public HtmlEditorMentionBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for mentions.</summary>
		[Generated]
		public HtmlEditorMentionBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for mentions.</summary>
		[Generated]
		public HtmlEditorMentionBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies a custom template for mentions.</summary>
		[Generated]
		public HtmlEditorMentionBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides unique values to the template's `id` parameter.</summary>
		[Generated]
		public HtmlEditorMentionBuilder ValueExpr(string value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides unique values to the template's `id` parameter.</summary>
		[Generated]
		public HtmlEditorMentionBuilder ValueExpr(JS value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}
	}
}
