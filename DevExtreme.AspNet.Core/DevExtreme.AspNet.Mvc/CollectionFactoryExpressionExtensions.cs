using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Factories;
using DevExtreme.AspNet.Mvc.Internals;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DevExtreme.AspNet.Mvc
{
	public static class CollectionFactoryExpressionExtensions
	{
		public static DataGridSummaryTotalItemBuilder<TRow> AddFor<TRow, TProperty>(this CollectionFactory<DataGridSummaryTotalItemBuilder<TRow>> factory, Expression<Func<TRow, TProperty>> expression)
		{
			return factory.Add(delegate(IHtmlHelperAdapter html, DataGridSummaryTotalItemBuilder<TRow> item)
			{
				item.Column(GetExpressionText(html, expression));
			});
		}

		public static DataGridSummaryTotalItemBuilder<TRow> AddFor<TRow, TColumn, TDisplayColumn>(this CollectionFactory<DataGridSummaryTotalItemBuilder<TRow>> factory, Expression<Func<TRow, TColumn>> column, Expression<Func<TRow, TDisplayColumn>> displayColumn)
		{
			return factory.Add(delegate(IHtmlHelperAdapter html, DataGridSummaryTotalItemBuilder<TRow> item)
			{
				item.Column(GetExpressionText(html, column));
				item.ShowInColumn(GetExpressionText(html, displayColumn));
			});
		}

		public static DataGridSummaryGroupItemBuilder<TRow> AddFor<TRow, TProperty>(this CollectionFactory<DataGridSummaryGroupItemBuilder<TRow>> factory, Expression<Func<TRow, TProperty>> expression)
		{
			return factory.Add(delegate(IHtmlHelperAdapter html, DataGridSummaryGroupItemBuilder<TRow> item)
			{
				item.Column(GetExpressionText(html, expression));
			});
		}

		public static DataGridSummaryGroupItemBuilder<TRow> AddFor<TRow, TColumn, TDisplayColumn>(this CollectionFactory<DataGridSummaryGroupItemBuilder<TRow>> factory, Expression<Func<TRow, TColumn>> column, Expression<Func<TRow, TDisplayColumn>> displayColumn)
		{
			return factory.Add(delegate(IHtmlHelperAdapter html, DataGridSummaryGroupItemBuilder<TRow> item)
			{
				item.Column(GetExpressionText(html, column));
				item.ShowInColumn(GetExpressionText(html, displayColumn));
			});
		}

		public static DataGridColumnBuilder<TRow> AddFor<TRow, TProperty>(this CollectionFactory<DataGridColumnBuilder<TRow>> factory, Expression<Func<TRow, TProperty>> expression)
		{
			return factory.Add(delegate(IHtmlHelperAdapter html, DataGridColumnBuilder<TRow> item)
			{
				string expressionText = GetExpressionText(html, expression);
				item.DataField(expressionText);
				ModelExplorer modelExplorer = GetModelExplorer(html, expression);
				ModelMetadata modelMetadata = modelExplorer?.Metadata;
				if (modelMetadata != null)
				{
					string displayName = GetDisplayName(modelMetadata);
					if (!string.IsNullOrEmpty(displayName))
					{
						item.Caption(displayName);
					}
					GridColumnDataType? gridColumnDataType = GetGridColumnDataType(modelMetadata);
					if (gridColumnDataType.HasValue)
					{
						item.DataType(gridColumnDataType.Value);
					}
					IEnumerable<IDictionary<string, object>> validationRules = DataAnnotationsHelper.GetValidationRules(expressionText, modelExplorer, html.ViewContext);
					if (validationRules.Any())
					{
						item.Options["validationRules"] = validationRules;
					}
				}
			});
		}

		public static TreeListColumnBuilder<TRow> AddFor<TRow, TProperty>(this CollectionFactory<TreeListColumnBuilder<TRow>> factory, Expression<Func<TRow, TProperty>> expression)
		{
			return factory.Add(delegate(IHtmlHelperAdapter html, TreeListColumnBuilder<TRow> item)
			{
				string expressionText = GetExpressionText(html, expression);
				item.DataField(expressionText);
				ModelExplorer modelExplorer = GetModelExplorer(html, expression);
				ModelMetadata modelMetadata = modelExplorer?.Metadata;
				if (modelMetadata != null)
				{
					string displayName = GetDisplayName(modelMetadata);
					if (!string.IsNullOrEmpty(displayName))
					{
						item.Caption(displayName);
					}
					GridColumnDataType? gridColumnDataType = GetGridColumnDataType(modelMetadata);
					if (gridColumnDataType.HasValue)
					{
						item.DataType(gridColumnDataType.Value);
					}
					IEnumerable<IDictionary<string, object>> validationRules = DataAnnotationsHelper.GetValidationRules(expressionText, modelExplorer, html.ViewContext);
					if (validationRules.Any())
					{
						item.Options["validationRules"] = validationRules;
					}
				}
			});
		}

		public static PivotGridDataSourceFieldBuilder<TField> AddFor<TField, TProperty>(this CollectionFactory<PivotGridDataSourceFieldBuilder<TField>> factory, Expression<Func<TField, TProperty>> expression)
		{
			return factory.Add(delegate(IHtmlHelperAdapter html, PivotGridDataSourceFieldBuilder<TField> item)
			{
				item.DataField(GetExpressionText(html, expression));
				ModelMetadata modelMetadata = GetModelExplorer(html, expression)?.Metadata;
				if (modelMetadata != null)
				{
					string displayName = GetDisplayName(modelMetadata);
					if (!string.IsNullOrEmpty(displayName))
					{
						item.Caption(displayName);
					}
					PivotGridDataType? pivotGridFieldDataType = GetPivotGridFieldDataType(modelMetadata);
					if (pivotGridFieldDataType.HasValue)
					{
						item.DataType(pivotGridFieldDataType.Value);
					}
				}
			});
		}

		public static FormSimpleItemBuilder AddSimpleFor<TFormData, TProperty>(this FormItemsFactory<TFormData> factory, Expression<Func<TFormData, TProperty>> expression)
		{
			return factory.AddSimple(delegate(IHtmlHelperAdapter html, FormSimpleItemBuilder item)
			{
				string expressionText = GetExpressionText(html, expression);
				item.DataField(expressionText);
				ModelExplorer modelExplorer = GetModelExplorer(html, expression);
				ModelMetadata modelMetadata = modelExplorer?.Metadata;
				if (modelMetadata != null)
				{
					Func<FormItemEditorFactory, WidgetBuilder> formItemEditor = GetFormItemEditor(modelMetadata);
					if (formItemEditor != null && !factory.HasParentOwner("dxDataGrid", "dxTreeList"))
					{
						item.Editor(formItemEditor);
					}
					string displayName = GetDisplayName(modelMetadata);
					if (!string.IsNullOrEmpty(displayName))
					{
						item.Label(delegate(FormItemLabelBuilder label)
						{
							label.Text(displayName);
						});
					}
					string displayPrompt = GetDisplayPrompt(modelMetadata);
					if (!string.IsNullOrEmpty(displayPrompt))
					{
						OptionsOwnerBuilder.GetNestedOptions(item.Options, "editorOptions")["placeholder"] = displayPrompt;
					}
					string displayDescription = GetDisplayDescription(modelMetadata);
					if (!string.IsNullOrEmpty(displayDescription))
					{
						item.HelpText(displayDescription);
					}
					IEnumerable<IDictionary<string, object>> validationRules = DataAnnotationsHelper.GetValidationRules(expressionText, modelExplorer, html.ViewContext);
					if (validationRules.Any())
					{
						item.Options["validationRules"] = validationRules;
					}
				}
			});
		}

		public static FilterBuilderFieldBuilder<TField> AddFor<TField, TProperty>(this CollectionFactory<FilterBuilderFieldBuilder<TField>> factory, Expression<Func<TField, TProperty>> expression)
		{
			return factory.Add(delegate(IHtmlHelperAdapter html, FilterBuilderFieldBuilder<TField> item)
			{
				string expressionText = GetExpressionText(html, expression);
				item.DataField(expressionText);
				ModelMetadata modelMetadata = GetModelExplorer(html, expression)?.Metadata;
				if (modelMetadata != null)
				{
					string displayName = GetDisplayName(modelMetadata);
					if (!string.IsNullOrEmpty(displayName))
					{
						item.Caption(displayName);
					}
					FilterBuilderFieldDataType? filterBuilderFieldDataType = GetFilterBuilderFieldDataType(modelMetadata);
					if (filterBuilderFieldDataType.HasValue)
					{
						item.DataType(filterBuilderFieldDataType.Value);
					}
				}
			});
		}

		private static Type GetModelType(ModelMetadata modelMetadata)
		{
			Type type = modelMetadata.ModelType;
			Type underlyingType = Nullable.GetUnderlyingType(type);
			if (underlyingType != null)
			{
				type = underlyingType;
			}
			return type;
		}

		private static GridColumnDataType? GetGridColumnDataType(ModelMetadata modelMetadata)
		{
			Type modelType = GetModelType(modelMetadata);
			if (modelType == typeof(string))
			{
				return GridColumnDataType.String;
			}
			if (modelType == typeof(bool))
			{
				return GridColumnDataType.Boolean;
			}
			if (modelType == typeof(DateTime))
			{
				return GridColumnDataType.Date;
			}
			if (IsNumericType(modelType))
			{
				return GridColumnDataType.Number;
			}
			return null;
		}

		private static PivotGridDataType? GetPivotGridFieldDataType(ModelMetadata modelMetadata)
		{
			Type modelType = GetModelType(modelMetadata);
			if (modelType == typeof(string))
			{
				return PivotGridDataType.String;
			}
			if (modelType == typeof(DateTime))
			{
				return PivotGridDataType.Date;
			}
			if (IsNumericType(modelType))
			{
				return PivotGridDataType.Number;
			}
			return null;
		}

		private static FilterBuilderFieldDataType? GetFilterBuilderFieldDataType(ModelMetadata modelMetadata)
		{
			Type modelType = GetModelType(modelMetadata);
			if (modelType == typeof(string))
			{
				return FilterBuilderFieldDataType.String;
			}
			if (modelType == typeof(bool))
			{
				return FilterBuilderFieldDataType.Boolean;
			}
			if (modelType == typeof(DateTime))
			{
				return FilterBuilderFieldDataType.Date;
			}
			if (IsNumericType(modelType))
			{
				return FilterBuilderFieldDataType.Number;
			}
			return null;
		}

		private static bool IsNumericType(Type type)
		{
			TypeCode typeCode = Type.GetTypeCode(type);
			if ((uint)(typeCode - 5) <= 5u || (uint)(typeCode - 13) <= 1u)
			{
				return true;
			}
			return false;
		}

		private static Func<FormItemEditorFactory, WidgetBuilder> GetFormItemEditor(ModelMetadata modelMetadata)
		{
			Type modelType = GetModelType(modelMetadata);
			if (modelType == typeof(string))
			{
				return (FormItemEditorFactory factory) => factory.TextBox();
			}
			if (modelType == typeof(bool))
			{
				return (FormItemEditorFactory factory) => factory.CheckBox();
			}
			if (modelType == typeof(DateTime))
			{
				return (FormItemEditorFactory factory) => factory.DateBox();
			}
			if (IsNumericType(modelType))
			{
				return (FormItemEditorFactory factory) => factory.NumberBox();
			}
			return null;
		}

		private static ModelExplorer GetModelExplorer<TModel, TProperty>(IHtmlHelperAdapter html, Expression<Func<TModel, TProperty>> expression)
		{
			ViewDataDictionary<TModel> viewData = new ViewDataDictionary<TModel>(html.ViewContext.ViewData, null);
			return Portability.GetModelExpressionProvider(html.ViewContext).GetModelExplorer(expression, viewData);
		}

		private static string GetDisplayName(ModelMetadata modelMetadata)
		{
			if (string.IsNullOrEmpty(modelMetadata.DisplayName))
			{
				return null;
			}
			return modelMetadata.GetDisplayName();
		}

		private static string GetDisplayPrompt(ModelMetadata modelMetadata)
		{
			if (string.IsNullOrEmpty(modelMetadata.Placeholder))
			{
				return null;
			}
			return modelMetadata.Placeholder;
		}

		private static string GetDisplayDescription(ModelMetadata modelMetadata)
		{
			if (string.IsNullOrEmpty(modelMetadata.Description))
			{
				return null;
			}
			return modelMetadata.Description;
		}

		private static string GetExpressionText<M, P>(IHtmlHelperAdapter html, Expression<Func<M, P>> expr)
		{
			return Portability.GetModelExpressionProvider(html.ViewContext).GetExpressionText(expr);
		}
	}
}
