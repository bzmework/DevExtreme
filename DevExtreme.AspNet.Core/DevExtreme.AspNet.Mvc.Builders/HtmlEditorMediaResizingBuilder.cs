using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	public class HtmlEditorMediaResizingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public HtmlEditorMediaResizingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public HtmlEditorMediaResizingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies media types that can be resized. Currently, only images are supported.</summary>
		[Generated]
		public HtmlEditorMediaResizingBuilder AllowedTargets(IEnumerable<string> value)
		{
			base.Options["allowedTargets"] = value;
			return this;
		}

		/// <summary>Specifies media types that can be resized. Currently, only images are supported.</summary>
		[Generated]
		public HtmlEditorMediaResizingBuilder AllowedTargets(JS value)
		{
			base.Options["allowedTargets"] = value;
			return this;
		}

		/// <summary>Enables media resizing.</summary>
		[Generated]
		public HtmlEditorMediaResizingBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables media resizing.</summary>
		[Generated]
		public HtmlEditorMediaResizingBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}
	}
}
