namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// ∂Øª≠≈‰÷√
	/// </summary>
	public class AnimationConfigBuilder : OptionsOwnerBuilder
	{
		/// <summary>
		/// ≥ı ºªØ
		/// </summary>
		/// <param name="context"></param>
		public AnimationConfigBuilder(OptionsOwnerContext context)
			: base(context)
		{
			//
		}

		public AnimationConfigBuilder Type(AnimationType value)
		{
			base.Options["type"] = value;
			return this;
		}

		public AnimationConfigBuilder Start(string jsFunc)
		{
			AssignJS("start", jsFunc);
			return this;
		}

		public AnimationConfigBuilder Start(RazorBlock jsFunc)
		{
			return Start(UnwrapJavaScriptFunc(jsFunc));
		}

		public AnimationConfigBuilder Complete(string jsFunc)
		{
			AssignJS("complete", jsFunc);
			return this;
		}

		public AnimationConfigBuilder Complete(RazorBlock jsFunc)
		{
			return Complete(UnwrapJavaScriptFunc(jsFunc));
		}

		public AnimationConfigBuilder Direction(Direction value)
		{
			base.Options["direction"] = value;
			return this;
		}

		public AnimationConfigBuilder Duration(double value)
		{
			base.Options["duration"] = value;
			return this;
		}

		public AnimationConfigBuilder Delay(double value)
		{
			base.Options["delay"] = value;
			return this;
		}

		public AnimationConfigBuilder StaggerDelay(double value)
		{
			base.Options["staggerDelay"] = value;
			return this;
		}

		public AnimationConfigBuilder Easing(AnimationEasing value)
		{
			base.Options["easing"] = value;
			return this;
		}

		public AnimationConfigBuilder EasingCubicBezier(double p1, double p2, double p3, double p4)
		{
			base.Options["easing"] = $"cubic-bezier({p1},{p2},{p3},{p4})";
			return this;
		}

		public AnimationConfigBuilder From(double value)
		{
			base.Options["from"] = value;
			return this;
		}

		public AnimationConfigBuilder From(string cssClassName)
		{
			base.Options["from"] = cssClassName;
			return this;
		}

		public AnimationConfigBuilder From(object options)
		{
			base.Options["from"] = options;
			return this;
		}

		public AnimationConfigBuilder To(double value)
		{
			base.Options["to"] = value;
			return this;
		}

		public AnimationConfigBuilder To(string cssClassName)
		{
			base.Options["to"] = cssClassName;
			return this;
		}

		public AnimationConfigBuilder To(object options)
		{
			base.Options["to"] = options;
			return this;
		}
	}
}
