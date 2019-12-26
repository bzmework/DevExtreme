namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Font options.</summary>
	public class VizFontBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public VizFontBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public VizFontBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font color.</summary>
		[Generated]
		public VizFontBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies font color.</summary>
		[Generated]
		public VizFontBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies font family.</summary>
		[Generated]
		public VizFontBuilder Family(string value)
		{
			base.Options["family"] = value;
			return this;
		}

		/// <summary>Specifies font family.</summary>
		[Generated]
		public VizFontBuilder Family(JS value)
		{
			base.Options["family"] = value;
			return this;
		}

		/// <summary>Specifies font opacity.</summary>
		[Generated]
		public VizFontBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies font opacity.</summary>
		[Generated]
		public VizFontBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies font size.</summary>
		[Generated]
		public VizFontBuilder Size(double value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specifies font size.</summary>
		[Generated]
		public VizFontBuilder Size(string value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specifies font size.</summary>
		[Generated]
		public VizFontBuilder Size(JS value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specifies font weight. Accepts values from 100 to 900 in increments of 100. Higher values increase boldness.</summary>
		[Generated]
		public VizFontBuilder Weight(double value)
		{
			base.Options["weight"] = value;
			return this;
		}

		/// <summary>Specifies font weight. Accepts values from 100 to 900 in increments of 100. Higher values increase boldness.</summary>
		[Generated]
		public VizFontBuilder Weight(JS value)
		{
			base.Options["weight"] = value;
			return this;
		}
	}
}
