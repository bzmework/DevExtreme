using DevExtreme.AspNet.Mvc.Internals;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExtreme.AspNet.Mvc
{
	public class ValidationGroup : IDisposable
	{
		private ViewContext _viewContext;

		private string Name
		{
			get
			{
				return Global.CurrentValidationGroup;
			}
			set
			{
				Global.CurrentValidationGroup = value;
			}
		}

		private GlobalOptions Global => GlobalOptions.Get(_viewContext.HttpContext);

		public ValidationGroup(ViewContext viewContext, string name)
		{
			_viewContext = viewContext;
			Name = (string.IsNullOrEmpty(name) ? GenerateID() : name);
			IEnumerable<string> propertyNamesWithModelErrors = GetPropertyNamesWithModelErrors();
			if (propertyNamesWithModelErrors.Count() > 0)
			{
				_viewContext.Writer.Write(RenderValidationScript(propertyNamesWithModelErrors));
			}
		}

		public ValidationGroup(ViewContext viewContext)
			: this(viewContext, null)
		{
		}

		public void Dispose()
		{
			Name = null;
		}

		protected virtual string GenerateID()
		{
			return Guid.NewGuid().ToString();
		}

		private IEnumerable<string> GetPropertyNamesWithModelErrors()
		{
			ViewDataDictionary viewData = _viewContext.ViewData;
			ModelMetadata modelMetadata = viewData.ModelMetadata;
			ModelStateDictionary modelState = viewData.ModelState;
			List<string> list = new List<string>();
			if (modelMetadata != null)
			{
				foreach (string key in modelState.Keys)
				{
					if (modelState[key].Errors.Count >= 1 && IsKnownModelProperty(modelMetadata, key.Split(new char[1]
					{
						'.'
					})))
					{
						list.Add(key);
					}
				}
				return list;
			}
			return list;
		}

		private static bool IsKnownModelProperty(ModelMetadata meta, IEnumerable<string> propertyPath)
		{
			string b = propertyPath.FirstOrDefault();
			foreach (ModelMetadata property in meta.Properties)
			{
				if (property.PropertyName == b)
				{
					string[] array = propertyPath.Skip(1).ToArray();
					if (array.Length == 0)
					{
						return true;
					}
					return IsKnownModelProperty(property, array);
				}
			}
			return false;
		}

		private string RenderValidationScript(IEnumerable<string> propertyNames)
		{
			return $"<script>\r\n                    $(function() {{\r\n                        setTimeout(function(){{\r\n                            DevExpress.aspnet.createValidationSummaryItems(\"{Name}\", {JsonUtils.SafeSerialize(propertyNames)});\r\n                        }});\r\n                    }});\r\n                </script>";
		}
	}
}
