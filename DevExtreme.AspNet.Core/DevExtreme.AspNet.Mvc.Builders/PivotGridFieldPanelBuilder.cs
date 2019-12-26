using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the field panel.</summary>
	public class PivotGridFieldPanelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PivotGridFieldPanelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PivotGridFieldPanelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Makes fields on the field panel draggable.</summary>
		[Generated]
		public PivotGridFieldPanelBuilder AllowFieldDragging(bool value)
		{
			base.Options["allowFieldDragging"] = value;
			return this;
		}

		/// <summary>Makes fields on the field panel draggable.</summary>
		[Generated]
		public PivotGridFieldPanelBuilder AllowFieldDragging(JS value)
		{
			base.Options["allowFieldDragging"] = value;
			return this;
		}

		/// <summary>Shows/hides column fields on the field panel.</summary>
		[Generated]
		public PivotGridFieldPanelBuilder ShowColumnFields(bool value)
		{
			base.Options["showColumnFields"] = value;
			return this;
		}

		/// <summary>Shows/hides column fields on the field panel.</summary>
		[Generated]
		public PivotGridFieldPanelBuilder ShowColumnFields(JS value)
		{
			base.Options["showColumnFields"] = value;
			return this;
		}

		/// <summary>Shows/hides data fields on the field panel.</summary>
		[Generated]
		public PivotGridFieldPanelBuilder ShowDataFields(bool value)
		{
			base.Options["showDataFields"] = value;
			return this;
		}

		/// <summary>Shows/hides data fields on the field panel.</summary>
		[Generated]
		public PivotGridFieldPanelBuilder ShowDataFields(JS value)
		{
			base.Options["showDataFields"] = value;
			return this;
		}

		/// <summary>Shows/hides filter fields on the field panel.</summary>
		[Generated]
		public PivotGridFieldPanelBuilder ShowFilterFields(bool value)
		{
			base.Options["showFilterFields"] = value;
			return this;
		}

		/// <summary>Shows/hides filter fields on the field panel.</summary>
		[Generated]
		public PivotGridFieldPanelBuilder ShowFilterFields(JS value)
		{
			base.Options["showFilterFields"] = value;
			return this;
		}

		/// <summary>Shows/hides row fields on the field panel.</summary>
		[Generated]
		public PivotGridFieldPanelBuilder ShowRowFields(bool value)
		{
			base.Options["showRowFields"] = value;
			return this;
		}

		/// <summary>Shows/hides row fields on the field panel.</summary>
		[Generated]
		public PivotGridFieldPanelBuilder ShowRowFields(JS value)
		{
			base.Options["showRowFields"] = value;
			return this;
		}

		/// <summary>Specifies the placeholders of the field areas.</summary>
		[Generated]
		public PivotGridFieldPanelBuilder Texts(Action<PivotGridFieldPanelTextsBuilder> configurator)
		{
			NestedOptions("texts", configurator);
			return this;
		}

		/// <summary>Shows/hides the field panel.</summary>
		[Generated]
		public PivotGridFieldPanelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Shows/hides the field panel.</summary>
		[Generated]
		public PivotGridFieldPanelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
