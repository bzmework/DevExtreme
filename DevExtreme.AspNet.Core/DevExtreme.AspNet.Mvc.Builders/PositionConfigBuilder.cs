namespace DevExtreme.AspNet.Mvc.Builders
{
	public class PositionConfigBuilder : OptionsOwnerBuilder
	{
		public PositionConfigBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		public PositionConfigBuilder At(HorizontalAlignment h, VerticalAlignment v)
		{
			base.Options["at"] = (h.ToString() + " " + v.ToString()).ToLower();
			return this;
		}

		public PositionConfigBuilder Boundary(string elementSelector)
		{
			base.Options["boundary"] = elementSelector;
			return this;
		}

		public PositionConfigBuilder Boundary(JS value)
		{
			base.Options["boundary"] = value;
			return this;
		}

		public PositionConfigBuilder BoundaryOffset(double horz, double vert)
		{
			base.Options["boundaryOffset"] = horz.ToString() + " " + vert.ToString();
			return this;
		}

		public PositionConfigBuilder Collision(PositionResolveCollision h, PositionResolveCollision v)
		{
			base.Options["collision"] = (h.ToString() + " " + v.ToString()).ToLower();
			return this;
		}

		public PositionConfigBuilder My(HorizontalAlignment h, VerticalAlignment v)
		{
			base.Options["my"] = (h.ToString() + " " + v.ToString()).ToLower();
			return this;
		}

		public PositionConfigBuilder Of(string elementSelector)
		{
			base.Options["of"] = elementSelector;
			return this;
		}

		public PositionConfigBuilder Of(JS value)
		{
			base.Options["of"] = value;
			return this;
		}

		public PositionConfigBuilder Offset(double h, double v)
		{
			base.Options["offset"] = h.ToString() + " " + v.ToString();
			return this;
		}
	}
}
