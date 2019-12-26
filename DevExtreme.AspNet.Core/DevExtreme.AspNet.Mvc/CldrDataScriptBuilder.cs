using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Reflection;

namespace DevExtreme.AspNet.Mvc
{
	public class CldrDataScriptBuilder
	{
		private string _cldrPath = string.Empty;

		private string[] _locales = new string[0];

		private string _initialLocale;

		public CldrDataScriptBuilder SetCldrPath(string virtualPath)
		{
			_cldrPath = virtualPath;
			return this;
		}

		public CldrDataScriptBuilder UseLocales(params string[] locales)
		{
			_locales = locales;
			return this;
		}

		public CldrDataScriptBuilder SetInitialLocale(string locale)
		{
			_initialLocale = locale;
			return this;
		}

		public ActionResult Build()
		{
			return new CldrDataResult(_cldrPath, _locales, _initialLocale);
		}

		public static string GetCacheParam()
		{
			return Convert.ToBase64String(BitConverter.GetBytes(File.GetLastWriteTime(GetExecutingAssembly().Location).ToBinary()));
		}

		private static Assembly GetExecutingAssembly()
		{
			return Assembly.GetEntryAssembly();
		}
	}
}
