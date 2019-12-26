using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.Encodings.Web;

namespace DevExtreme.AspNet.Mvc
{
	internal static class Portability
	{
		internal interface IModelExpressionProviderAdapter
		{
			string GetExpressionText<M, P>(Expression<Func<M, P>> expr);

			ModelExplorer GetModelExplorer(string expr, ViewDataDictionary viewData);

			ModelExplorer GetModelExplorer<M, P>(Expression<Func<M, P>> expr, ViewDataDictionary<M> viewData);
		}

		private class NetCore2Impl : IModelExpressionProviderAdapter
		{
			private readonly IModelMetadataProvider MetadataProvider;

			public NetCore2Impl(IModelMetadataProvider metadataProvider)
			{
				MetadataProvider = metadataProvider;
			}

			public string GetExpressionText<M, P>(Expression<Func<M, P>> expr)
			{
				return ExpressionHelper.GetExpressionText(expr);
			}

			public ModelExplorer GetModelExplorer(string expr, ViewDataDictionary viewData)
			{
				return ExpressionMetadataProvider.FromStringExpression(expr, viewData, MetadataProvider);
			}

			public ModelExplorer GetModelExplorer<M, P>(Expression<Func<M, P>> expr, ViewDataDictionary<M> viewData)
			{
				return ExpressionMetadataProvider.FromLambdaExpression(expr, viewData, MetadataProvider);
			}
		}

		private class NetCore3Impl : IModelExpressionProviderAdapter
		{
			private static readonly MethodInfo GetExpressionTextMethod;

			private static readonly MethodInfo CreateModelExpressionByStringMethod;

			private readonly IModelExpressionProvider ExpressionProvider;

			static NetCore3Impl()
			{
				GetExpressionTextMethod = typeof(ModelExpressionProvider).GetMethod("GetExpressionText");
				CreateModelExpressionByStringMethod = typeof(ModelExpressionProvider).GetMethods().First((MethodInfo m) => m.Name == "CreateModelExpression" && m.IsGenericMethod && m.GetGenericArguments().Length == 1);
			}

			public NetCore3Impl(IModelExpressionProvider expressionProvider)
			{
				ExpressionProvider = expressionProvider;
			}

			public string GetExpressionText<M, P>(Expression<Func<M, P>> expr)
			{
				return (string)GetExpressionTextMethod.MakeGenericMethod(typeof(M), typeof(P)).Invoke(ExpressionProvider, new object[1]
				{
					expr
				});
			}

			public ModelExplorer GetModelExplorer(string expr, ViewDataDictionary viewData)
			{
				Type type = typeof(object);
				Type type2 = viewData.GetType();
				if (type2.IsGenericType)
				{
					type = type2.GetGenericArguments().First();
				}
				else
				{
					viewData = new ViewDataDictionary<object>(viewData);
				}
				return ((ModelExpression)CreateModelExpressionByStringMethod.MakeGenericMethod(type).Invoke(ExpressionProvider, new object[2]
				{
					viewData,
					expr
				})).ModelExplorer;
			}

			public ModelExplorer GetModelExplorer<M, P>(Expression<Func<M, P>> expr, ViewDataDictionary<M> viewData)
			{
				return ExpressionProvider.CreateModelExpression(viewData, expr).ModelExplorer;
			}
		}

		public static readonly int ASPNETCORE_VERSION = typeof(IActionResult).Assembly.GetName().Version.Major;

		public static string GetContentUrl(ViewContext viewContext, string virtualPath)
		{
			return GetUrlHelper(viewContext).Content(virtualPath);
		}

		public static string GetActionUrl(ViewContext viewContext, string routeName, IDictionary<string, object> routeValues)
		{
			return GetUrlHelper(viewContext).RouteUrl(routeName, new RouteValueDictionary(routeValues));
		}

		public static void RenderHtmlString(IHtmlContent subj, TextWriter output)
		{
			subj.WriteTo(output, HtmlEncoder.Default);
		}

		public static object GetFormValue(ViewContext viewContext, string key)
		{
			FormContext formContext = viewContext.FormContext;
			if (formContext.HasFormData)
			{
				return formContext.FormData[key];
			}
			return null;
		}

		private static IUrlHelper GetUrlHelper(ActionContext context)
		{
			return context.HttpContext.RequestServices.GetRequiredService<IUrlHelperFactory>().GetUrlHelper(context);
		}

		public static Stream GetRequestFileStream(HttpRequest request)
		{
			IFormFileCollection files = request.Form.Files;
			if (files.Any())
			{
				return files[0].OpenReadStream();
			}
			return Stream.Null;
		}

		public static ActionResult CreateFileContentResult(Stream fileStream, string fileName)
		{
			return new FileStreamResult(fileStream, "application/octet-stream")
			{
				FileDownloadName = fileName
			};
		}

		public static IModelExpressionProviderAdapter GetModelExpressionProvider(ViewContext viewContext)
		{
			IServiceProvider requestServices = viewContext.HttpContext.RequestServices;
			if (ASPNETCORE_VERSION < 3)
			{
				return new NetCore2Impl(requestServices.GetRequiredService<IModelMetadataProvider>());
			}
			return new NetCore3Impl(requestServices.GetRequiredService<IModelExpressionProvider>());
		}
	}
}
