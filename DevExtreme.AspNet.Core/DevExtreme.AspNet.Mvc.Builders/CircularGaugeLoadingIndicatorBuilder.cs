using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the loading indicator.</summary>
	public class CircularGaugeLoadingIndicatorBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public CircularGaugeLoadingIndicatorBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public CircularGaugeLoadingIndicatorBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the background of the loading indicator.</summary>
		[Generated]
		public CircularGaugeLoadingIndicatorBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Colors the background of the loading indicator.</summary>
		[Generated]
		public CircularGaugeLoadingIndicatorBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies font options for the loading indicator.</summary>
		[Generated]
		public CircularGaugeLoadingIndicatorBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Allows you to change the loading indicator's visibility.</summary>
		[Generated]
		public CircularGaugeLoadingIndicatorBuilder Show(bool value)
		{
			base.Options["show"] = value;
			return this;
		}

		/// <summary>Allows you to change the loading indicator's visibility.</summary>
		[Generated]
		public CircularGaugeLoadingIndicatorBuilder Show(JS value)
		{
			base.Options["show"] = value;
			return this;
		}

		/// <summary>Specifies the text to be displayed by the loading indicator.</summary>
		[Generated]
		public CircularGaugeLoadingIndicatorBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the text to be displayed by the loading indicator.</summary>
		[Generated]
		public CircularGaugeLoadingIndicatorBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}
	}
}
