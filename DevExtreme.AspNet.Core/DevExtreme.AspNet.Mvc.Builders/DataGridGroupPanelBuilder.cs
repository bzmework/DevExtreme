namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the group panel.</summary>
	public class DataGridGroupPanelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridGroupPanelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridGroupPanelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether columns can be dragged onto or from the group panel.</summary>
		[Generated]
		public DataGridGroupPanelBuilder AllowColumnDragging(bool value)
		{
			base.Options["allowColumnDragging"] = value;
			return this;
		}

		/// <summary>Specifies whether columns can be dragged onto or from the group panel.</summary>
		[Generated]
		public DataGridGroupPanelBuilder AllowColumnDragging(JS value)
		{
			base.Options["allowColumnDragging"] = value;
			return this;
		}

		/// <summary>Specifies text displayed by the group panel when it does not contain any columns.</summary>
		[Generated]
		public DataGridGroupPanelBuilder EmptyPanelText(string value)
		{
			base.Options["emptyPanelText"] = value;
			return this;
		}

		/// <summary>Specifies text displayed by the group panel when it does not contain any columns.</summary>
		[Generated]
		public DataGridGroupPanelBuilder EmptyPanelText(JS value)
		{
			base.Options["emptyPanelText"] = value;
			return this;
		}

		/// <summary>Specifies whether the group panel is visible or not.</summary>
		[Generated]
		public DataGridGroupPanelBuilder Visible(Mode value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the group panel is visible or not.</summary>
		[Generated]
		public DataGridGroupPanelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the group panel is visible or not.</summary>
		[Generated]
		public DataGridGroupPanelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
