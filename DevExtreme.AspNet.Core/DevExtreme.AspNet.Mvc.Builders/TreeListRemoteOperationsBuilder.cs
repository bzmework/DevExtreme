namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Notifies the TreeList of the server's data processing operations. Applies only if data has a plain structure.</summary>
	public class TreeListRemoteOperationsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeListRemoteOperationsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListRemoteOperationsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether filtering should be performed on the server.</summary>
		[Generated]
		public TreeListRemoteOperationsBuilder Filtering(bool value)
		{
			base.Options["filtering"] = value;
			return this;
		}

		/// <summary>Specifies whether filtering should be performed on the server.</summary>
		[Generated]
		public TreeListRemoteOperationsBuilder Filtering(JS value)
		{
			base.Options["filtering"] = value;
			return this;
		}

		/// <summary>Specifies whether grouping should be performed on the server.</summary>
		[Generated]
		public TreeListRemoteOperationsBuilder Grouping(bool value)
		{
			base.Options["grouping"] = value;
			return this;
		}

		/// <summary>Specifies whether grouping should be performed on the server.</summary>
		[Generated]
		public TreeListRemoteOperationsBuilder Grouping(JS value)
		{
			base.Options["grouping"] = value;
			return this;
		}

		/// <summary>Specifies whether sorting should be performed on the server.</summary>
		[Generated]
		public TreeListRemoteOperationsBuilder Sorting(bool value)
		{
			base.Options["sorting"] = value;
			return this;
		}

		/// <summary>Specifies whether sorting should be performed on the server.</summary>
		[Generated]
		public TreeListRemoteOperationsBuilder Sorting(JS value)
		{
			base.Options["sorting"] = value;
			return this;
		}
	}
}
