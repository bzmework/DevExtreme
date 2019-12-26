namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies range selector shutter options.</summary>
	public class RangeSelectorShutterBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSelectorShutterBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorShutterBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies shutter color.</summary>
		[Generated]
		public RangeSelectorShutterBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies shutter color.</summary>
		[Generated]
		public RangeSelectorShutterBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the color of shutters.</summary>
		[Generated]
		public RangeSelectorShutterBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the color of shutters.</summary>
		[Generated]
		public RangeSelectorShutterBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}
	}
}
