namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>A key used to authenticate the application within the required map provider.</summary>
	public class MapKeyBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public MapKeyBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public MapKeyBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>A key used to authenticate the application within the "Bing" map provider.</summary>
		[Generated]
		public MapKeyBuilder Bing(string value)
		{
			base.Options["bing"] = value;
			return this;
		}

		/// <summary>A key used to authenticate the application within the "Bing" map provider.</summary>
		[Generated]
		public MapKeyBuilder Bing(JS value)
		{
			base.Options["bing"] = value;
			return this;
		}

		/// <summary>A key used to authenticate the application within the "Google" map provider.</summary>
		[Generated]
		public MapKeyBuilder Google(string value)
		{
			base.Options["google"] = value;
			return this;
		}

		/// <summary>A key used to authenticate the application within the "Google" map provider.</summary>
		[Generated]
		public MapKeyBuilder Google(JS value)
		{
			base.Options["google"] = value;
			return this;
		}

		/// <summary>A key used to authenticate the application within the "Google Static" map provider.</summary>
		[Generated]
		public MapKeyBuilder GoogleStatic(string value)
		{
			base.Options["googleStatic"] = value;
			return this;
		}

		/// <summary>A key used to authenticate the application within the "Google Static" map provider.</summary>
		[Generated]
		public MapKeyBuilder GoogleStatic(JS value)
		{
			base.Options["googleStatic"] = value;
			return this;
		}
	}
}
