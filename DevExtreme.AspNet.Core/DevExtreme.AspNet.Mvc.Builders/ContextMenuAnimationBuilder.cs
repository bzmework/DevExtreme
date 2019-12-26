using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures widget visibility animations. This object contains two fields: show and hide.</summary>
	public class ContextMenuAnimationBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ContextMenuAnimationBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ContextMenuAnimationBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>An object that defines the animation options used when the widget is being hidden.</summary>
		[Generated]
		public ContextMenuAnimationBuilder Hide(Action<AnimationConfigBuilder> configurator)
		{
			NestedOptions("hide", configurator);
			return this;
		}

		/// <summary>An object that defines the animation options used when the widget is being shown.</summary>
		[Generated]
		public ContextMenuAnimationBuilder Show(Action<AnimationConfigBuilder> configurator)
		{
			NestedOptions("show", configurator);
			return this;
		}
	}
}
