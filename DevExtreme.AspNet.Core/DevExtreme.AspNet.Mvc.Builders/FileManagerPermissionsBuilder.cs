namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies actions that a user is allowed to perform on files and folders.</summary>
	public class FileManagerPermissionsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FileManagerPermissionsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FileManagerPermissionsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether a user is allowed to copy files and folders.</summary>
		[Generated]
		public FileManagerPermissionsBuilder Copy(bool value)
		{
			base.Options["copy"] = value;
			return this;
		}

		/// <summary>Specifies whether a user is allowed to copy files and folders.</summary>
		[Generated]
		public FileManagerPermissionsBuilder Copy(JS value)
		{
			base.Options["copy"] = value;
			return this;
		}

		/// <summary>Specifies whether a user is allowed to create files and folders.</summary>
		[Generated]
		public FileManagerPermissionsBuilder Create(bool value)
		{
			base.Options["create"] = value;
			return this;
		}

		/// <summary>Specifies whether a user is allowed to create files and folders.</summary>
		[Generated]
		public FileManagerPermissionsBuilder Create(JS value)
		{
			base.Options["create"] = value;
			return this;
		}

		/// <summary>Specifies whether a user is allowed to download files and folders.</summary>
		[Generated]
		public FileManagerPermissionsBuilder Download(bool value)
		{
			base.Options["download"] = value;
			return this;
		}

		/// <summary>Specifies whether a user is allowed to download files and folders.</summary>
		[Generated]
		public FileManagerPermissionsBuilder Download(JS value)
		{
			base.Options["download"] = value;
			return this;
		}

		/// <summary>Specifies whether a user is allowed to move files and folders.</summary>
		[Generated]
		public FileManagerPermissionsBuilder Move(bool value)
		{
			base.Options["move"] = value;
			return this;
		}

		/// <summary>Specifies whether a user is allowed to move files and folders.</summary>
		[Generated]
		public FileManagerPermissionsBuilder Move(JS value)
		{
			base.Options["move"] = value;
			return this;
		}

		/// <summary>Specifies whether a user is allowed to remove files and folders.</summary>
		[Generated]
		public FileManagerPermissionsBuilder Remove(bool value)
		{
			base.Options["remove"] = value;
			return this;
		}

		/// <summary>Specifies whether a user is allowed to remove files and folders.</summary>
		[Generated]
		public FileManagerPermissionsBuilder Remove(JS value)
		{
			base.Options["remove"] = value;
			return this;
		}

		/// <summary>Specifies whether a user is allowed to rename files and folders.</summary>
		[Generated]
		public FileManagerPermissionsBuilder Rename(bool value)
		{
			base.Options["rename"] = value;
			return this;
		}

		/// <summary>Specifies whether a user is allowed to rename files and folders.</summary>
		[Generated]
		public FileManagerPermissionsBuilder Rename(JS value)
		{
			base.Options["rename"] = value;
			return this;
		}

		/// <summary>Specifies whether a user is allowed to upload files.</summary>
		[Generated]
		public FileManagerPermissionsBuilder Upload(bool value)
		{
			base.Options["upload"] = value;
			return this;
		}

		/// <summary>Specifies whether a user is allowed to upload files.</summary>
		[Generated]
		public FileManagerPermissionsBuilder Upload(JS value)
		{
			base.Options["upload"] = value;
			return this;
		}
	}
}
