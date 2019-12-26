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
	/// HtmlHelper������ 
	/// </summary>
	public interface IHtmlHelperAdapter
	{
		/// <summary>
		/// ��ͼ������
		/// </summary>
		ViewContext ViewContext
		{
			get;
		}

		/// <summary>
		/// TextWriter�����ջ
		/// </summary>
		Stack<TextWriter> OutputStack
		{
			get;
		}

		/// <summary>
		/// �����������ɵ�ID
		/// </summary>
		/// <param name="fullName"></param>
		/// <returns></returns>
		string GenerateIdFromName(string fullName);

		/// <summary>
		/// �����Դģ��
		/// </summary>
		/// <typeparam name="TModel"></typeparam>
		/// <typeparam name="TProperty"></typeparam>
		/// <param name="expression"></param>
		/// <returns></returns>
		[Obsolete]
		[EditorBrowsable(EditorBrowsableState.Never)]
		ModelExplorer GetModelSource<TModel, TProperty>(Expression<Func<TModel, TProperty>> expression);

		/// <summary>
		/// �����Դģ��
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
