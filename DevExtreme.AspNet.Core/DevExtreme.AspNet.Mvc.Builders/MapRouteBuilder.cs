using DevExtreme.AspNet.Mvc.Factories;
using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An array of routes shown on the map.</summary>
	public class MapRouteBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public MapRouteBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public MapRouteBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of the line displaying the route.</summary>
		[Generated]
		public MapRouteBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the line displaying the route.</summary>
		[Generated]
		public MapRouteBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Contains an array of objects making up the route.</summary>
		[Generated]
		public MapRouteBuilder Locations(Action<CollectionFactory<MapRoutesLocationBuilder>> configurator)
		{
			Collection("locations", configurator);
			return this;
		}

		/// <summary>Specifies a transportation mode to be used in the displayed route.</summary>
		[Generated]
		public MapRouteBuilder Mode(GeoMapRouteMode value)
		{
			base.Options["mode"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the line displaying the route.</summary>
		[Generated]
		public MapRouteBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the line displaying the route.</summary>
		[Generated]
		public MapRouteBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the thickness of the line displaying the route in pixels.</summary>
		[Generated]
		public MapRouteBuilder Weight(double value)
		{
			base.Options["weight"] = value;
			return this;
		}

		/// <summary>Specifies the thickness of the line displaying the route in pixels.</summary>
		[Generated]
		public MapRouteBuilder Weight(JS value)
		{
			base.Options["weight"] = value;
			return this;
		}
	}
}
