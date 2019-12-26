using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Contains an array of objects making up the route.</summary>
	public class MapRoutesLocationBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		private object _value;

		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public MapRoutesLocationBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public MapRoutesLocationBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		public MapRoutesLocationBuilder Address(string address)
		{
			_value = address;
			return this;
		}

		public MapRoutesLocationBuilder Coordinates(double latitude, double longitude)
		{
			_value = new double[2]
			{
				latitude,
				longitude
			};
			return this;
		}

		protected internal override void AttachCollectionItemToParent(IDictionary<string, object> parentOptions)
		{
			this.AttachCollectionItem(parentOptions, base.JsName, _value);
		}
	}
}
