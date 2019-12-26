using DevExtreme.AspNet.Mvc.Factories;
using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	public class TextEditorButtonBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public TextEditorButtonBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TextEditorButtonBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether to place the button before or after the input text field.</summary>
		[Generated]
		public TextEditorButtonBuilder Location(TextEditorButtonLocation value)
		{
			base.Options["location"] = value;
			return this;
		}

		/// <summary>Specifies the button's name.</summary>
		[Generated]
		public TextEditorButtonBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the button's name.</summary>
		[Generated]
		public TextEditorButtonBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>A widget that presents a editor button.</summary>
		public TextEditorButtonBuilder Widget(Func<TextEditorButtonWidgetFactory, WidgetBuilder> widgetFactory)
		{
			NestedWidget(widgetFactory, "widget", "options");
			return this;
		}
	}
}
