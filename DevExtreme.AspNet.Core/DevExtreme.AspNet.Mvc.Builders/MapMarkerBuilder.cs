using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An array of markers displayed on a map.</summary>
	public class MapMarkerBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public MapMarkerBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public MapMarkerBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>A URL pointing to the custom icon to be used for the marker.</summary>
		[Generated]
		public MapMarkerBuilder IconSrc(string value)
		{
			base.Options["iconSrc"] = value;
			return this;
		}

		/// <summary>A URL pointing to the custom icon to be used for the marker.</summary>
		[Generated]
		public MapMarkerBuilder IconSrc(JS value)
		{
			base.Options["iconSrc"] = value;
			return this;
		}

		/// <summary>A callback function performed when the marker is clicked.</summary>
		[Generated]
		public MapMarkerBuilder OnClick(string jsFunc)
		{
			AssignJS("onClick", jsFunc);
			return this;
		}

		/// <summary>A callback function performed when the marker is clicked.</summary>
		[Generated]
		public MapMarkerBuilder OnClick(RazorBlock jsFunc)
		{
			return OnClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A tooltip to be used for the marker.</summary>
		[Generated]
		public MapMarkerBuilder Tooltip(Action<MapMarkersTooltipBuilder> configurator)
		{
			NestedOptions("tooltip", configurator);
			return this;
		}

		/// <summary>A tooltip to be used for the marker.</summary>
		[Generated]
		public MapMarkerBuilder Tooltip(string value)
		{
			base.Options["tooltip"] = value;
			return this;
		}

		/// <summary>A tooltip to be used for the marker.</summary>
		[Generated]
		public MapMarkerBuilder Tooltip(JS value)
		{
			base.Options["tooltip"] = value;
			return this;
		}

		public MapMarkerBuilder Address(string address)
		{
			base.Options["location"] = address;
			return this;
		}

		public MapMarkerBuilder Coordinates(double latitude, double longitude)
		{
			base.Options["location"] = new double[2]
			{
				latitude,
				longitude
			};
			return this;
		}
	}
}
