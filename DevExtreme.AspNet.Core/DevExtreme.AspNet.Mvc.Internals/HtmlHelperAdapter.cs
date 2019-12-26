using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq.Expressions;

namespace DevExtreme.AspNet.Mvc.Internals
{
	public class HtmlHelperAdapter : IHtmlHelperAdapter
	{
		private IHtmlHelper _html;

		public ViewContext ViewContext => _html.ViewContext;

		public Stack<TextWriter> OutputStack => null;

		public HtmlHelperAdapter(IHtmlHelper html)
		{
			_html = html;
		}

		public string GenerateIdFromName(string fullName)
		{
			return _html.GenerateIdFromName(fullName);
		}

		[Obsolete]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ModelExplorer GetModelSource<TModel, TProperty>(Expression<Func<TModel, TProperty>> expression)
		{
			return GetModelSource(expression, new ViewDataDictionary<TModel>(ViewContext.ViewData));
		}

		[Obsolete]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ModelExplorer GetModelSource<TModel, TProperty>(Expression<Func<TModel, TProperty>> expression, ViewDataDictionary<TModel> viewData)
		{
			return Portability.GetModelExpressionProvider(ViewContext).GetModelExplorer(expression, viewData);
		}
	}
}
