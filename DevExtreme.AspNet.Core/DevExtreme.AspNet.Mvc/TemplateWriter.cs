using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace DevExtreme.AspNet.Mvc
{
	internal class TemplateWriter
	{
		private TextWriter _htmlWriter;

		public TemplateWriter(TextWriter htmlWriter)
		{
			_htmlWriter = htmlWriter;
		}

		public void WriteTemplate(string id, string body)
		{
			WriteStart(id);
			WriteBody(body);
			WriteEnd();
		}

		public void WriteStart(string id)
		{
			_htmlWriter.Write("<script type=\"text/html\" id=\"");
			_htmlWriter.Write(WebUtility.HtmlEncode(id));
			_htmlWriter.Write("\">");
		}

		public void WriteBody(string body)
		{
			_htmlWriter.Write(EscapeScriptInTemplate(body));
		}

		public void WriteEnd()
		{
			_htmlWriter.Write("</script>");
		}

		private string EscapeScriptInTemplate(string template)
		{
			return Regex.Replace(template, "</(script)>", "</<% %>$1>", RegexOptions.IgnoreCase);
		}
	}
}
