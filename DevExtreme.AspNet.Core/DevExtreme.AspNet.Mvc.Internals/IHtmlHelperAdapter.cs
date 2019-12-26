using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq.Expressions;

namespace DevExtreme.AspNet.Mvc.Internals
{
	/// <summary>
	/// HtmlHelper适配器 
	/// </summary>
	public interface IHtmlHelperAdapter
	{
		/// <summary>
		/// 视图上下文
		/// </summary>
		ViewContext ViewContext
		{
			get;
		}

		/// <summary>
		/// TextWriter输出堆栈
		/// </summary>
		Stack<TextWriter> OutputStack
		{
			get;
		}

		/// <summary>
		/// 根据名称生成的ID
		/// </summary>
		/// <param name="fullName"></param>
		/// <returns></returns>
		string GenerateIdFromName(string fullName);

		/// <summary>
		/// 获得来源模型
		/// </summary>
		/// <typeparam name="TModel"></typeparam>
		/// <typeparam name="TProperty"></typeparam>
		/// <param name="expression"></param>
		/// <returns></returns>
		[Obsolete]
		[EditorBrowsable(EditorBrowsableState.Never)]
		ModelExplorer GetModelSource<TModel, TProperty>(Expression<Func<TModel, TProperty>> expression);

		/// <summary>
		/// 获得来源模型
		/// </summary>
		/// <typeparam name="TModel"></typeparam>
		/// <typeparam name="TProperty"></typeparam>
		/// <param name="expression"></param>
		/// <param name="viewData"></param>
		/// <returns></returns>
		[Obsolete]
		[EditorBrowsable(EditorBrowsableState.Never)]
		ModelExplorer GetModelSource<TModel, TProperty>(Expression<Func<TModel, TProperty>> expression, ViewDataDictionary<TModel> viewData);
	}
}
