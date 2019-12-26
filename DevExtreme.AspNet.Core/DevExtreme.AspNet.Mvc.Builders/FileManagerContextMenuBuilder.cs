using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the context menu settings.</summary>
	public class FileManagerContextMenuBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FileManagerContextMenuBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FileManagerContextMenuBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures context menu items' settings.</summary>
		[Generated]
		public FileManagerContextMenuBuilder Items(Action<CollectionFactory<FileManagerContextMenuItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>Configures context menu items' settings.</summary>
		[Generated]
		public FileManagerContextMenuBuilder Items(IEnumerable<FileManagerContextMenuItem> value)
		{
			base.Options["items"] = value;
			return this;
		}
	}
}
