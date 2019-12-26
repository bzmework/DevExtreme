using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Internals
{
	public class GlobalOptions
	{
		private int _templateLevel;

		private int _serial;

		public bool ConfigScriptBlockRendered
		{
			get;
			set;
		}

		public string CurrentValidationGroup
		{
			get;
			set;
		}

		public List<Tuple<string, string>> Templates
		{
			get;
		} = new List<Tuple<string, string>>();


		public static GlobalOptions Get(HttpContext ctx)
		{
			if (ctx.Items["9aa5bc80-f773-4eda-b97d-b6c920144399"] == null)
			{
				ctx.Items["9aa5bc80-f773-4eda-b97d-b6c920144399"] = new GlobalOptions();
			}
			return (GlobalOptions)ctx.Items["9aa5bc80-f773-4eda-b97d-b6c920144399"];
		}

		public void EnterTemplate()
		{
			_templateLevel++;
		}

		public void LeaveTemplate()
		{
			_templateLevel--;
		}

		public bool InTemplate()
		{
			return _templateLevel > 0;
		}

		public int NextSerial()
		{
			return _serial++;
		}
	}
}
