using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevExtreme.AspNet.Mvc
{
	internal static class DataAnnotationsHelper
	{
		private static IDictionary<string, string> validationTypesMap = new Dictionary<string, string>
		{
			["required"] = "required",
			["range"] = "range",
			["length"] = "stringLength",
			["regex"] = "pattern",
			["custom"] = "custom",
			["equalto"] = "compare",
			["devextremeRequired"] = "required",
			["remote"] = "async"
		};

		public static IEnumerable<IDictionary<string, object>> GetValidationRulesByPropertyName(string propertyName, ViewContext viewContext)
		{
			if (!string.IsNullOrEmpty(propertyName))
			{
				ModelExplorer modelExplorer = Portability.GetModelExpressionProvider(viewContext).GetModelExplorer(propertyName, viewContext.ViewData);
				return GetValidationRules(propertyName, modelExplorer, viewContext);
			}
			return Enumerable.Empty<IDictionary<string, object>>();
		}

		public static IEnumerable<IDictionary<string, object>> GetValidationRules(string propertyName, ModelExplorer modelExplorer, ViewContext viewContext)
		{
			List<IDictionary<string, object>> list = new List<IDictionary<string, object>>();
			ModelMetadata modelMetadata = modelExplorer?.Metadata;
			if (modelMetadata != null)
			{
				IDictionary<string, string> validationAttributes = GetValidationAttributes(viewContext, modelExplorer, propertyName);
				{
					foreach (KeyValuePair<string, string> item in validationAttributes)
					{
						string text = item.Key.Replace("data-val-", "");
						bool flag = text.StartsWith("custom") && text.Split(new char[1]
						{
							'-'
						}).Length == 2;
						if ((validationTypesMap.ContainsKey(text) && !SkipValidationRule(text, modelMetadata)) | flag)
						{
							Dictionary<string, object> dictionary = new Dictionary<string, object>();
							string text2 = "data-val-" + text + "-";
							foreach (KeyValuePair<string, string> item2 in validationAttributes)
							{
								if (item2.Key.Contains(text2))
								{
									string text3 = item2.Key.Replace(text2, "");
									object value = (text3 != "pattern") ? ((object)new JS(item2.Value)) : item2.Value;
									dictionary.Add(text3, value);
								}
							}
							text = (flag ? "custom" : text);
							list.Add(CreateClientValidationRule(propertyName, text, item.Value, dictionary));
						}
					}
					return list;
				}
			}
			return list;
		}

		private static bool SkipValidationRule(string validationType, ModelMetadata modelMetadata)
		{
			if (validationType != "required" || !Compatibility.Validation.IgnoreRequiredForBoolean)
			{
				return false;
			}
			Type modelType = modelMetadata.ModelType;
			if (!(modelType == typeof(bool)))
			{
				return modelType == typeof(bool?);
			}
			return true;
		}

		private static IDictionary<string, object> CreateClientValidationRule(string propertyName, string validationType, string errorMessage, IDictionary<string, object> validationParameters)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>
			{
				["type"] = validationTypesMap[validationType],
				["message"] = errorMessage
			};
			PrepareValidationParameters(propertyName, validationType, validationParameters);
			validationParameters.AddTo(dictionary);
			return dictionary;
		}

		private static void PrepareValidationParameters(string propertyName, string validationType, IDictionary<string, object> validationParameters)
		{
			if (validationType == "range" && DateTime.TryParse(validationParameters["min"].ToString(), out DateTime result) && DateTime.TryParse(validationParameters["max"].ToString(), out DateTime result2))
			{
				validationParameters["min"] = result;
				validationParameters["max"] = result2;
			}
			if (validationType == "equalto")
			{
				string text = validationParameters["other"].ToString();
				string str = propertyName.Substring(0, propertyName.LastIndexOf('.') + 1) + text.Substring((text.IndexOf("*.") == 0) ? 2 : 0);
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("function(){");
				stringBuilder.Append("return DevExpress.aspnet.getEditorValue(\"" + str + "\");");
				stringBuilder.Append("}");
				validationParameters.Add("comparisonTarget", new JRaw(stringBuilder.ToString()));
				validationParameters.Remove("other");
			}
			if (validationType == "custom" && (validationParameters.TryGetValue("validationcallback", out object value) || validationParameters.TryGetValue("validationCallback", out value)))
			{
				validationParameters["validationCallback"] = new JRaw(value);
				if (validationParameters.ContainsKey("validationcallback"))
				{
					validationParameters.Remove("validationcallback");
				}
			}
			if (validationType == "remote")
			{
				string text2 = validationParameters["url"].ToString();
				validationParameters.Remove("url");
				string text3 = "GET";
				if (validationParameters.ContainsKey("type"))
				{
					text3 = validationParameters["type"].ToString();
					validationParameters.Remove("type");
				}
				StringBuilder stringBuilder2 = new StringBuilder();
				stringBuilder2.Append("function(params){");
				stringBuilder2.Append("return DevExpress.aspnet.sendValidationRequest(\"" + propertyName + "\", params.value, \"" + text2 + "\", \"" + text3 + "\");");
				stringBuilder2.Append("}");
				validationParameters.Add("validationCallback", new JRaw(stringBuilder2.ToString()));
				validationParameters.Remove("additionalfields");
			}
		}

		private static IDictionary<string, string> GetValidationAttributes(ViewContext viewContext, ModelExplorer modelExplorer, string propertyName)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			viewContext.HttpContext.RequestServices.GetService<ValidationHtmlAttributeProvider>()?.AddValidationAttributes(viewContext, modelExplorer, dictionary);
			return dictionary;
		}
	}
}
