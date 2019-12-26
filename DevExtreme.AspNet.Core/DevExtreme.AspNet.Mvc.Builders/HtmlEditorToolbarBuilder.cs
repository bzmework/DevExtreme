using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	public class HtmlEditorToolbarBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public HtmlEditorToolbarBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public HtmlEditorToolbarBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the container in which to place the toolbar.</summary>
		[Generated]
		public HtmlEditorToolbarBuilder Container(string value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies the container in which to place the toolbar.</summary>
		[Generated]
		public HtmlEditorToolbarBuilder Container(JS value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Configures toolbar items. These items allow users to format text and execute commands.</summary>
		[Generated]
		public HtmlEditorToolbarBuilder Items(IEnumerable<HtmlEditorToolbarItem> value)
		{
			base.Options["items"] = value;
			return this;
		}

		/// <summary>Configures toolbar items. These items allow users to format text and execute commands.</summary>
		[Generated]
		public HtmlEditorToolbarBuilder Items(Action<CollectionFactory<HtmlEditorToolbarItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}
	}
}
