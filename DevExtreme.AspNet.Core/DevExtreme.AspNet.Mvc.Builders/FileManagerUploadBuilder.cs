namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures upload settings.</summary>
	public class FileManagerUploadBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FileManagerUploadBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FileManagerUploadBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the maximum upload file size.</summary>
		[Generated]
		public FileManagerUploadBuilder MaxFileSize(double value)
		{
			base.Options["maxFileSize"] = value;
			return this;
		}

		/// <summary>Specifies the maximum upload file size.</summary>
		[Generated]
		public FileManagerUploadBuilder MaxFileSize(JS value)
		{
			base.Options["maxFileSize"] = value;
			return this;
		}
	}
}
