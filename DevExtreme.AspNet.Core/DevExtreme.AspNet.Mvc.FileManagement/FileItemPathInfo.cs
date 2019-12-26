using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq;

namespace DevExtreme.AspNet.Mvc.FileManagement
{
	public class FileItemPathInfo
	{
		private FileItemIdentifier<JToken>[] PathInfo
		{
			get;
		}

		internal static FileItemPathInfo Create(JArray pathInfo)
		{
			return new FileItemPathInfo(pathInfo);
		}

		internal FileItemPathInfo(JArray pathInfo)
		{
			if (pathInfo == null)
			{
				pathInfo = new JArray();
			}
			PathInfo = pathInfo.Select((JToken info) => new FileItemIdentifier<JToken>
			{
				Key = info["key"],
				Name = info["name"]?.ToString()
			}).ToArray();
		}

		public string GetPath()
		{
			return Path.Combine(PathInfo.Select((FileItemIdentifier<JToken> p) => p.Name).ToArray());
		}

		public FileItemIdentifier<TKey>[] GetPathParts<TKey>()
		{
			return PathInfo.Select((FileItemIdentifier<JToken> info) => new FileItemIdentifier<TKey>
			{
				Key = info.Key.Value<TKey>(),
				Name = info.Name
			}).ToArray();
		}

		public TKey GetFileItemKey<TKey>()
		{
			JToken jToken = PathInfo.Any() ? PathInfo.Last().Key : null;
			if (jToken == null)
			{
				return default(TKey);
			}
			return jToken.Value<TKey>();
		}

		public string GetFileItemName()
		{
			if (!PathInfo.Any())
			{
				return null;
			}
			return PathInfo.Last().Name;
		}
	}
}
