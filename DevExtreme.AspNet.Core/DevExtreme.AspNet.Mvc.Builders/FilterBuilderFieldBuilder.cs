using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The FilterBuilder's field structure.</summary>
	public class FilterBuilderFieldBuilder<T> : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public FilterBuilderFieldBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the field's custom filtering rules.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> CalculateFilterExpression(string jsFunc)
		{
			AssignJS("calculateFilterExpression", jsFunc);
			return this;
		}

		/// <summary>Specifies the field's custom filtering rules.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> CalculateFilterExpression(RazorBlock jsFunc)
		{
			return CalculateFilterExpression(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the data field's caption.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> Caption(string value)
		{
			base.Options["caption"] = value;
			return this;
		}

		/// <summary>Specifies the data field's caption.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> Caption(JS value)
		{
			base.Options["caption"] = value;
			return this;
		}

		/// <summary>Customizes the input value's display text.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Customizes the input value's display text.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the name of a field to be filtered.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> DataField(string value)
		{
			base.Options["dataField"] = value;
			return this;
		}

		/// <summary>Specifies the name of a field to be filtered.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> DataField(JS value)
		{
			base.Options["dataField"] = value;
			return this;
		}

		/// <summary>Casts field values to a specific data type.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> DataType(FilterBuilderFieldDataType value)
		{
			base.Options["dataType"] = value;
			return this;
		}

		/// <summary>Configures the widget used to edit the field value.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> EditorOptions(object value)
		{
			base.Options["editorOptions"] = value;
			return this;
		}

		/// <summary>Specifies the editor's custom template.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> EditorTemplate(string templateContent)
		{
			AssignTemplate("editorTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies the editor's custom template.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> EditorTemplate(RazorBlock templateContent)
		{
			AssignTemplate("editorTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies the editor's custom template.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> EditorTemplate(TemplateName name)
		{
			AssignTemplate("editorTemplate", name);
			return this;
		}

		/// <summary>Specifies the editor's custom template.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> EditorTemplate(JS value)
		{
			base.Options["editorTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the false value text. Applies only if dataType is "boolean".</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> FalseText(string value)
		{
			base.Options["falseText"] = value;
			return this;
		}

		/// <summary>Specifies the false value text. Applies only if dataType is "boolean".</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> FalseText(JS value)
		{
			base.Options["falseText"] = value;
			return this;
		}

		/// <summary>Specifies a set of available filter operations.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> FilterOperations(IEnumerable<FilterBuilderFieldFilterOperations> value)
		{
			base.Options["filterOperations"] = value;
			return this;
		}

		/// <summary>Specifies a set of available filter operations.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> FilterOperations(IEnumerable<string> value)
		{
			base.Options["filterOperations"] = value;
			return this;
		}

		/// <summary>Specifies a set of available filter operations.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> FilterOperations(JS value)
		{
			base.Options["filterOperations"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Configures the lookup field.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> Lookup(Action<FilterBuilderFieldLookupBuilder> configurator)
		{
			NestedOptions("lookup", configurator);
			return this;
		}

		/// <summary>Specifies the field's name. Use it to distinguish the field from other fields when they have identical dataField values.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the field's name. Use it to distinguish the field from other fields when they have identical dataField values.</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the true value text. Applies only if dataType is "boolean".</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> TrueText(string value)
		{
			base.Options["trueText"] = value;
			return this;
		}

		/// <summary>Specifies the true value text. Applies only if dataType is "boolean".</summary>
		[Generated]
		public FilterBuilderFieldBuilder<T> TrueText(JS value)
		{
			base.Options["trueText"] = value;
			return this;
		}
	}
}
