using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Internals;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DevExtreme.AspNet.Mvc
{
	internal static class InternalExtensions
	{
		public static void AttachCollectionItem(this OptionsOwnerBuilder builder, IDictionary<string, object> parentOptions, string jsName, object item)
		{
			if (!parentOptions.ContainsKey(jsName))
			{
				parentOptions[jsName] = new List<object>();
			}
			((IList)parentOptions[jsName]).Add(item);
		}

		public static void AddTo<T>(this IEnumerable<T> source, ICollection<T> target)
		{
			foreach (T item in source)
			{
				target.Add(item);
			}
		}

		public static T GetSafe<T>(this IDictionary<string, object> dict, string key)
		{
			if (dict.ContainsKey(key))
			{
				object obj = dict[key];
				if (obj is T)
				{
					return (T)obj;
				}
			}
			return default(T);
		}

		public static void PrepareEditorFor<TModel, TProperty>(this WidgetBuilder builder, IHtmlHelperAdapter html, Expression<Func<TModel, TProperty>> expression)
		{
			ViewContext viewContext = html.ViewContext;
			Portability.IModelExpressionProviderAdapter modelExpressionProvider = Portability.GetModelExpressionProvider(viewContext);
			ModelExplorer modelExplorer = modelExpressionProvider.GetModelExplorer(expression, new ViewDataDictionary<TModel>(viewContext.ViewData));
			string expressionText = modelExpressionProvider.GetExpressionText(expression);
			builder.Options["name"] = expressionText;
			builder.Options["value"] = modelExplorer?.Model;
			builder.ValidationRules = DataAnnotationsHelper.GetValidationRules(expressionText, modelExplorer, viewContext);
		}
	}
}
