using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	public class FilterBuilderCustomOperationBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public FilterBuilderCustomOperationBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FilterBuilderCustomOperationBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a function that returns a filter expression for this custom operation.</summary>
		[Generated]
		public FilterBuilderCustomOperationBuilder CalculateFilterExpression(string jsFunc)
		{
			AssignJS("calculateFilterExpression", jsFunc);
			return this;
		}

		/// <summary>Specifies a function that returns a filter expression for this custom operation.</summary>
		[Generated]
		public FilterBuilderCustomOperationBuilder CalculateFilterExpression(RazorBlock jsFunc)
		{
			return CalculateFilterExpression(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the operation's caption.</summary>
		[Generated]
		public FilterBuilderCustomOperationBuilder Caption(string value)
		{
			base.Options["caption"] = value;
			return this;
		}

		/// <summary>Specifies the operation's caption.</summary>
		[Generated]
		public FilterBuilderCustomOperationBuilder Caption(JS value)
		{
			base.Options["caption"] = value;
			return this;
		}

		/// <summary>Customizes the field value's text representation.</summary>
		[Generated]
		public FilterBuilderCustomOperationBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Customizes the field value's text representation.</summary>
		[Generated]
		public FilterBuilderCustomOperationBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies for which data types the operation is available by default.</summary>
		[Generated]
		public FilterBuilderCustomOperationBuilder DataTypes(IEnumerable<FilterBuilderFieldDataType> value)
		{
			base.Options["dataTypes"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the widget used to edit the field value.</summary>
		[Generated]
		public FilterBuilderCustomOperationBuilder EditorTemplate(string templateContent)
		{
			AssignTemplate("editorTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the widget used to edit the field value.</summary>
		[Generated]
		public FilterBuilderCustomOperationBuilder EditorTemplate(RazorBlock templateContent)
		{
			AssignTemplate("editorTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the widget used to edit the field value.</summary>
		[Generated]
		public FilterBuilderCustomOperationBuilder EditorTemplate(TemplateName name)
		{
			AssignTemplate("editorTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the widget used to edit the field value.</summary>
		[Generated]
		public FilterBuilderCustomOperationBuilder EditorTemplate(JS value)
		{
			base.Options["editorTemplate"] = value;
			return this;
		}

		/// <summary>Specifies whether the operation can have a value. If it can, the editor is displayed.</summary>
		[Generated]
		public FilterBuilderCustomOperationBuilder HasValue(bool value)
		{
			base.Options["hasValue"] = value;
			return this;
		}

		/// <summary>Specifies whether the operation can have a value. If it can, the editor is displayed.</summary>
		[Generated]
		public FilterBuilderCustomOperationBuilder HasValue(JS value)
		{
			base.Options["hasValue"] = value;
			return this;
		}

		/// <summary>Specifies the icon that should represent the filter operation.</summary>
		[Generated]
		public FilterBuilderCustomOperationBuilder Icon(string value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>Specifies the icon that should represent the filter operation.</summary>
		[Generated]
		public FilterBuilderCustomOperationBuilder Icon(JS value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>Specifies the operation's identifier.</summary>
		[Generated]
		public FilterBuilderCustomOperationBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the operation's identifier.</summary>
		[Generated]
		public FilterBuilderCustomOperationBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}
	}
}
