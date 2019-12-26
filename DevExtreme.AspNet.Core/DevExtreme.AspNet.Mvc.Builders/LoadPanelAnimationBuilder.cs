using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures widget visibility animations. This object contains two fields: show and hide.</summary>
	public class LoadPanelAnimationBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public LoadPanelAnimationBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public LoadPanelAnimationBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>An object that defines the animation options used when the widget is being hidden.</summary>
		[Generated]
		public LoadPanelAnimationBuilder Hide(Action<AnimationConfigBuilder> configurator)
		{
			NestedOptions("hide", configurator);
			return this;
		}

		/// <summary>An object that defines the animation options used when the widget is being shown.</summary>
		[Generated]
		public LoadPanelAnimationBuilder Show(Action<AnimationConfigBuilder> configurator)
		{
			NestedOptions("show", configurator);
			return this;
		}
	}
}
