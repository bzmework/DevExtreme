namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Notifies the DataGrid of the server's data processing operations.</summary>
	public class DataGridRemoteOperationsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridRemoteOperationsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridRemoteOperationsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether or not filtering must be performed on the server side.</summary>
		[Generated]
		public DataGridRemoteOperationsBuilder Filtering(bool value)
		{
			base.Options["filtering"] = value;
			return this;
		}

		/// <summary>Specifies whether or not filtering must be performed on the server side.</summary>
		[Generated]
		public DataGridRemoteOperationsBuilder Filtering(JS value)
		{
			base.Options["filtering"] = value;
			return this;
		}

		/// <summary>Specifies whether or not grouping must be performed on the server side.</summary>
		[Generated]
		public DataGridRemoteOperationsBuilder Grouping(bool value)
		{
			base.Options["grouping"] = value;
			return this;
		}

		/// <summary>Specifies whether or not grouping must be performed on the server side.</summary>
		[Generated]
		public DataGridRemoteOperationsBuilder Grouping(JS value)
		{
			base.Options["grouping"] = value;
			return this;
		}

		/// <summary>Specifies whether paging by groups should be performed on the server side.</summary>
		[Generated]
		public DataGridRemoteOperationsBuilder GroupPaging(bool value)
		{
			base.Options["groupPaging"] = value;
			return this;
		}

		/// <summary>Specifies whether paging by groups should be performed on the server side.</summary>
		[Generated]
		public DataGridRemoteOperationsBuilder GroupPaging(JS value)
		{
			base.Options["groupPaging"] = value;
			return this;
		}

		/// <summary>Specifies whether or not paging must be performed on the server side.</summary>
		[Generated]
		public DataGridRemoteOperationsBuilder Paging(bool value)
		{
			base.Options["paging"] = value;
			return this;
		}

		/// <summary>Specifies whether or not paging must be performed on the server side.</summary>
		[Generated]
		public DataGridRemoteOperationsBuilder Paging(JS value)
		{
			base.Options["paging"] = value;
			return this;
		}

		/// <summary>Specifies whether or not sorting must be performed on the server side.</summary>
		[Generated]
		public DataGridRemoteOperationsBuilder Sorting(bool value)
		{
			base.Options["sorting"] = value;
			return this;
		}

		/// <summary>Specifies whether or not sorting must be performed on the server side.</summary>
		[Generated]
		public DataGridRemoteOperationsBuilder Sorting(JS value)
		{
			base.Options["sorting"] = value;
			return this;
		}

		/// <summary>Specifies whether or not summaries calculation must be performed on the server.</summary>
		[Generated]
		public DataGridRemoteOperationsBuilder Summary(bool value)
		{
			base.Options["summary"] = value;
			return this;
		}

		/// <summary>Specifies whether or not summaries calculation must be performed on the server.</summary>
		[Generated]
		public DataGridRemoteOperationsBuilder Summary(JS value)
		{
			base.Options["summary"] = value;
			return this;
		}
	}
}
