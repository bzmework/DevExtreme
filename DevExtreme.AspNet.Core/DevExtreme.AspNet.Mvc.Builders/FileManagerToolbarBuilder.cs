using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures toolbar settings.</summary>
	public class FileManagerToolbarBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FileManagerToolbarBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FileManagerToolbarBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures settings of the toolbar items that are visible when users select files.</summary>
		[Generated]
		public FileManagerToolbarBuilder FileSelectionItems(IEnumerable<FileManagerToolbarItem> value)
		{
			base.Options["fileSelectionItems"] = value;
			return this;
		}

		/// <summary>Configures settings of the toolbar items that are visible when users select files.</summary>
		[Generated]
		public FileManagerToolbarBuilder FileSelectionItems(Action<CollectionFactory<FileManagerToolbarItemBuilder>> configurator)
		{
			Collection("fileSelectionItems", configurator);
			return this;
		}

		/// <summary>Configures toolbar items' settings.</summary>
		[Generated]
		public FileManagerToolbarBuilder Items(IEnumerable<FileManagerToolbarItem> value)
		{
			base.Options["items"] = value;
			return this;
		}

		/// <summary>Configures toolbar items' settings.</summary>
		[Generated]
		public FileManagerToolbarBuilder Items(Action<CollectionFactory<FileManagerToolbarItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}
	}
}
