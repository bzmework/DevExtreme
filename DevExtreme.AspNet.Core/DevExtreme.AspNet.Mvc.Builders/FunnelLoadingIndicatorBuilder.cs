using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the loading indicator.</summary>
	public class FunnelLoadingIndicatorBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FunnelLoadingIndicatorBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FunnelLoadingIndicatorBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the background of the loading indicator.</summary>
		[Generated]
		public FunnelLoadingIndicatorBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Colors the background of the loading indicator.</summary>
		[Generated]
		public FunnelLoadingIndicatorBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies whether the loading indicator should be displayed and hidden automatically.</summary>
		[Generated]
		public FunnelLoadingIndicatorBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the loading indicator should be displayed and hidden automatically.</summary>
		[Generated]
		public FunnelLoadingIndicatorBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies font options for the loading indicator.</summary>
		[Generated]
		public FunnelLoadingIndicatorBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Allows you to change the loading indicator's visibility.</summary>
		[Generated]
		public FunnelLoadingIndicatorBuilder Show(bool value)
		{
			base.Options["show"] = value;
			return this;
		}

		/// <summary>Allows you to change the loading indicator's visibility.</summary>
		[Generated]
		public FunnelLoadingIndicatorBuilder Show(JS value)
		{
			base.Options["show"] = value;
			return this;
		}

		/// <summary>Specifies the text to be displayed by the loading indicator.</summary>
		[Generated]
		public FunnelLoadingIndicatorBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the text to be displayed by the loading indicator.</summary>
		[Generated]
		public FunnelLoadingIndicatorBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}
	}
}
