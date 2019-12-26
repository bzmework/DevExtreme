namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the file and folder view.</summary>
	public class FileManagerItemViewBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FileManagerItemViewBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FileManagerItemViewBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the file system representation mode.</summary>
		[Generated]
		public FileManagerItemViewBuilder Mode(FileManagerItemViewMode value)
		{
			base.Options["mode"] = value;
			return this;
		}

		/// <summary>Specifies whether to display folders in the view. When this option is false, folders are displayed in the navigation pane only.</summary>
		[Generated]
		public FileManagerItemViewBuilder ShowFolders(bool value)
		{
			base.Options["showFolders"] = value;
			return this;
		}

		/// <summary>Specifies whether to display folders in the view. When this option is false, folders are displayed in the navigation pane only.</summary>
		[Generated]
		public FileManagerItemViewBuilder ShowFolders(JS value)
		{
			base.Options["showFolders"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the parent folder in the view.</summary>
		[Generated]
		public FileManagerItemViewBuilder ShowParentFolder(bool value)
		{
			base.Options["showParentFolder"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the parent folder in the view.</summary>
		[Generated]
		public FileManagerItemViewBuilder ShowParentFolder(JS value)
		{
			base.Options["showParentFolder"] = value;
			return this;
		}
	}
}
