using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders.DataSources
{
	public class DataSourceSortBuilder : OptionsOwnerBuilder
	{
		private List<object> _descriptors = new List<object>();

		internal static object CreateSortInfo(string selector, bool desc)
		{
			if (!desc)
			{
				return selector;
			}
			return new
			{
				selector = selector,
				desc = true
			};
		}

		public DataSourceSortBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>
		/// Adds a sorting option.
		/// </summary>
		/// <param name="fieldName">The name of the field that provides sorting values.</param>
		/// <param name="desc">A flag specifying whether to sort data in descending order.</param>
		public DataSourceSortBuilder AddSorting(string fieldName, bool desc = false)
		{
			_descriptors.Add(CreateSortInfo(fieldName, desc));
			return this;
		}

		protected internal override void AttachNestedOptionsToParent(IDictionary<string, object> parentOptions)
		{
			parentOptions[base.JsName] = _descriptors;
		}
	}
}
