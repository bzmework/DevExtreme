using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Helpers
{
	internal class FormSimpleItemCollector
	{
		private IDictionary<string, object> _formOptions;

		public FormSimpleItemCollector(IDictionary<string, object> formOptions)
		{
			_formOptions = formOptions;
		}

		public ICollection<IDictionary<string, object>> Collect()
		{
			List<IDictionary<string, object>> list = new List<IDictionary<string, object>>();
			Collect(_formOptions.GetSafe<IEnumerable>("items"), list);
			return list;
		}

		private static void Collect(IEnumerable items, ICollection<IDictionary<string, object>> resultItems)
		{
			if (items != null)
			{
				foreach (object item in items)
				{
					IDictionary<string, object> dictionary = item as IDictionary<string, object>;
					if (dictionary != null)
					{
						switch (dictionary.GetSafe<string>("itemType"))
						{
						case "simple":
							resultItems.Add(dictionary);
							break;
						case "group":
							Collect(dictionary.GetSafe<IEnumerable>("items"), resultItems);
							break;
						case "tabbed":
							foreach (object item2 in dictionary.GetSafe<IEnumerable>("tabs"))
							{
								IDictionary<string, object> dictionary2 = item2 as IDictionary<string, object>;
								if (dictionary2 != null)
								{
									Collect(dictionary2.GetSafe<IEnumerable>("items"), resultItems);
								}
							}
							break;
						}
					}
				}
			}
		}
	}
}
