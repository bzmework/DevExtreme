using DevExtreme.AspNet.Mvc.Internals;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace DevExtreme.AspNet.Mvc
{
	internal class Renderer
	{
		public string PluginName;

		public ComponentID ElementID;

		public ViewContext ViewContext;

		public IDictionary<string, object> Options;

		public IEnumerable<Tuple<string, string>> Templates;

		public IEnumerable<IDictionary<string, object>> ValidationRules;

		public string TranscludedContent;

		public string CurrentValidationGroup;

		public bool RequireStartupScriptID;

		public void RenderWithUnderscore(StringBuilder builder)
		{
			string validationConfig = GetValidationConfig();
			string arg = ElementID.IsAssigned ? JsonUtils.SafeSerialize(ElementID.ToJS()) : "\"dx-\" + new DevExpress.data.Guid()";
			string arg2 = JsonUtils.SafeSerialize(PluginName);
			string arg3 = JsonUtils.SafeSerialize(Options);
			builder.Append("<%!function(){%>").AppendFormat("<div id=\"<%=arguments[0]%>\">{0}</div>", TranscludedContent).AppendFormat("<%DevExpress.aspnet.createComponent({0},{1},arguments[0]", arg2, arg3);
			if (!string.IsNullOrEmpty(validationConfig))
			{
				builder.AppendFormat(",{0}", validationConfig);
			}
			builder.AppendFormat(")%><%}}({0})%>", arg);
		}

		public void RenderWithStaticMarkup(StringBuilder builder)
		{
			string @static = ElementID.GetStatic();
			builder.Append("<div id=\"").Append(WebUtility.HtmlEncode(@static)).Append("\">")
				.Append(TranscludedContent)
				.Append("</div>");
			if (Templates != null)
			{
				using (StringWriter htmlWriter = new StringWriter(builder))
				{
					TemplateWriter templateWriter = new TemplateWriter(htmlWriter);
					foreach (Tuple<string, string> template in Templates)
					{
						templateWriter.WriteTemplate(template.Item1, template.Item2);
					}
				}
			}
			RenderStartupScriptOpenTag(builder, RequireStartupScriptID ? @static : null);
			bool useJQueryReady = Compatibility.Rendering.UseJQueryReady;
			if (useJQueryReady)
			{
				builder.Append("jQuery(function($){");
			}
			else
			{
				builder.Append("DevExpress.utils.readyCallbacks.add((function($){");
			}
			builder.Append(FormatJQueryByID(@static)).Append(".").Append(PluginName)
				.Append("(")
				.Append(JsonUtils.SafeSerialize(Options))
				.Append(")");
			RenderValidator(builder);
			if (useJQueryReady)
			{
				builder.Append(";})");
			}
			else
			{
				builder.Append(";}).bind(this, jQuery))");
			}
			builder.Append(";</script>");
		}

		public static string FormatJQueryByID(string id)
		{
			return "$(" + JsonUtils.SafeSerialize("#" + Regex.Replace(id, "[^\\w<&>-]", "\\$&")) + ")";
		}

		public static void RenderStartupScriptOpenTag(StringBuilder builder, string id)
		{
			builder.Append("<script");
			if (!string.IsNullOrEmpty(id))
			{
				builder.Append(" id=\"dxss_").Append(WebUtility.HtmlEncode(id)).Append("\"");
			}
			builder.Append(">");
		}

		private void RenderValidator(StringBuilder sb)
		{
			string validationConfig = GetValidationConfig();
			if (!string.IsNullOrEmpty(validationConfig))
			{
				sb.Append(".dxValidator(");
				sb.Append(validationConfig);
				sb.Append(")");
			}
		}

		private string GetValidationConfig()
		{
			string result = string.Empty;
			if (ValidationRules != null && ValidationRules.Count() > 0)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>
				{
					["validationRules"] = ValidationRules
				};
				if (!string.IsNullOrEmpty(CurrentValidationGroup))
				{
					dictionary.Add("validationGroup", CurrentValidationGroup);
				}
				result = JsonUtils.SafeSerialize(dictionary);
			}
			return result;
		}
	}
}
