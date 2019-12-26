using System;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>A configuration object specifying scrolling options.</summary>
	public class PivotGridScrollingBuilder : OptionsOwnerBuilder
	{
		/// <summary>Specifies whether or not the widget uses native scrolling.</summary>
		[Obsolete("Use UseNative(bool value) instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public PivotGridScrollingBuilder UseNative(string value)
		{
			base.Options["useNative"] = value;
			return this;
		}

		[Generated]
		public PivotGridScrollingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PivotGridScrollingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the scrolling mode.</summary>
		[Generated]
		public PivotGridScrollingBuilder Mode(PivotGridScrollingMode value)
		{
			base.Options["mode"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget uses native scrolling.</summary>
		[Generated]
		public PivotGridScrollingBuilder UseNative(bool value)
		{
			base.Options["useNative"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget uses native scrolling.</summary>
		[Generated]
		public PivotGridScrollingBuilder UseNative(JS value)
		{
			base.Options["useNative"] = value;
			return this;
		}
	}
}
