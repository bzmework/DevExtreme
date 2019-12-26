using DevExtreme.AspNet.Mvc.Internals;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc
{
	internal class NamedTemplate : IDisposable
	{
		private GlobalOptions _globals;

		private TemplateWriter _writer;

		public NamedTemplate(ViewContext viewContext, string name)
		{
			_globals = GlobalOptions.Get(viewContext.HttpContext);
			_writer = new TemplateWriter(viewContext.Writer);
			if (_globals.InTemplate())
			{
				throw new InvalidOperationException("A named template cannot be defined inside any template.");
			}
			_writer.WriteStart(name);
			_globals.EnterTemplate();
		}

		public void Dispose()
		{
			_globals.LeaveTemplate();
			_writer.WriteEnd();
			List<Tuple<string, string>> templates = _globals.Templates;
			foreach (Tuple<string, string> item in templates)
			{
				_writer.WriteTemplate(item.Item1, item.Item2);
			}
			templates.Clear();
		}
	}
}
