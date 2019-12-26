namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies which editing operations an end-user can perform on appointments.</summary>
	public class SchedulerEditingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SchedulerEditingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SchedulerEditingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can add appointments.</summary>
		[Generated]
		public SchedulerEditingBuilder AllowAdding(bool value)
		{
			base.Options["allowAdding"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can add appointments.</summary>
		[Generated]
		public SchedulerEditingBuilder AllowAdding(JS value)
		{
			base.Options["allowAdding"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can delete appointments.</summary>
		[Generated]
		public SchedulerEditingBuilder AllowDeleting(bool value)
		{
			base.Options["allowDeleting"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can delete appointments.</summary>
		[Generated]
		public SchedulerEditingBuilder AllowDeleting(JS value)
		{
			base.Options["allowDeleting"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can drag appointments.</summary>
		[Generated]
		public SchedulerEditingBuilder AllowDragging(bool value)
		{
			base.Options["allowDragging"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can drag appointments.</summary>
		[Generated]
		public SchedulerEditingBuilder AllowDragging(JS value)
		{
			base.Options["allowDragging"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can change an appointment duration.</summary>
		[Generated]
		public SchedulerEditingBuilder AllowResizing(bool value)
		{
			base.Options["allowResizing"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can change an appointment duration.</summary>
		[Generated]
		public SchedulerEditingBuilder AllowResizing(JS value)
		{
			base.Options["allowResizing"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can change appointment options.</summary>
		[Generated]
		public SchedulerEditingBuilder AllowUpdating(bool value)
		{
			base.Options["allowUpdating"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can change appointment options.</summary>
		[Generated]
		public SchedulerEditingBuilder AllowUpdating(JS value)
		{
			base.Options["allowUpdating"] = value;
			return this;
		}
	}
}
