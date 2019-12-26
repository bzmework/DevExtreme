using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the loading indicator.</summary>
	public class VectorMapLoadingIndicatorBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public VectorMapLoadingIndicatorBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public VectorMapLoadingIndicatorBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the background of the loading indicator.</summary>
		[Generated]
		public VectorMapLoadingIndicatorBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Colors the background of the loading indicator.</summary>
		[Generated]
		public VectorMapLoadingIndicatorBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies whether the loading indicator should be displayed and hidden automatically.</summary>
		[Generated]
		public VectorMapLoadingIndicatorBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the loading indicator should be displayed and hidden automatically.</summary>
		[Generated]
		public VectorMapLoadingIndicatorBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies font options for the loading indicator.</summary>
		[Generated]
		public VectorMapLoadingIndicatorBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Allows you to change the loading indicator's visibility.</summary>
		[Generated]
		public VectorMapLoadingIndicatorBuilder Show(bool value)
		{
			base.Options["show"] = value;
			return this;
		}

		/// <summary>Allows you to change the loading indicator's visibility.</summary>
		[Generated]
		public VectorMapLoadingIndicatorBuilder Show(JS value)
		{
			base.Options["show"] = value;
			return this;
		}

		/// <summary>Specifies the text to be displayed by the loading indicator.</summary>
		[Generated]
		public VectorMapLoadingIndicatorBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the text to be displayed by the loading indicator.</summary>
		[Generated]
		public VectorMapLoadingIndicatorBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}
	}
}
