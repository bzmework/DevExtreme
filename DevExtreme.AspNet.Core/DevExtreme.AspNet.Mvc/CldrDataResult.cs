using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace DevExtreme.AspNet.Mvc
{
	internal class CldrDataResult : ActionResult
	{
		private string _cldrPath;

		private string[] _locales;

		private string _initialLocale;

		public CldrDataResult(string cldrPath, string[] locales, string initialLocale)
		{
			_cldrPath = cldrPath;
			_locales = locales;
			_initialLocale = initialLocale;
		}

		public override void ExecuteResult(ActionContext context)
		{
			HttpContext httpContext = context.HttpContext;
			_cldrPath = GetCldrPath(httpContext);
			SetCacheHeader(httpContext);
			using (StreamWriter streamWriter = new StreamWriter(GetOutputStream(httpContext)))
			{
				streamWriter.Write("Globalize.load({0});", JsonUtils.SafeSerialize(CreateCldrData()));
				if (!string.IsNullOrEmpty(_initialLocale))
				{
					streamWriter.Write("Globalize.locale({0});", JsonUtils.SafeSerialize(_initialLocale));
				}
			}
		}

		private IEnumerable<JObject> CreateCldrData()
		{
			foreach (string item in EnumerateCldrFiles())
			{
				yield return JsonConvert.DeserializeObject<JObject>(File.ReadAllText(item));
			}
		}

		private IEnumerable<string> EnumerateCldrFiles()
		{
			string[] locales = _locales;
			foreach (string path in locales)
			{
				foreach (string item in Directory.EnumerateFiles(Path.Combine(_cldrPath, "main", path), "*.json"))
				{
					yield return item;
				}
			}
			foreach (string item2 in Directory.EnumerateFiles(Path.Combine(_cldrPath, "supplemental"), "*.json"))
			{
				yield return item2;
			}
		}

		private void SetCacheHeader(HttpContext http)
		{
			TimeSpan timeSpan = TimeSpan.FromDays(730.0);
			http.Response.ContentType = "application/javascript";
			http.Response.Headers["Cache-Control"] = "max-age=" + timeSpan.TotalSeconds.ToString();
		}

		private string GetCldrPath(HttpContext http)
		{
			string contentRootPath = http.RequestServices.GetRequiredService<IHostingEnvironment>().ContentRootPath;
			return _cldrPath.Replace("~", contentRootPath);
		}

		private static Stream GetOutputStream(HttpContext http)
		{
			return http.Response.Body;
		}
	}
}
