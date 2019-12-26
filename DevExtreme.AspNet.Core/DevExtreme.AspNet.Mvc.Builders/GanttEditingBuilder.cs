namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures edit options.</summary>
	public class GanttEditingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public GanttEditingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public GanttEditingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether a user can add dependencies.</summary>
		[Generated]
		public GanttEditingBuilder AllowDependencyAdding(bool value)
		{
			base.Options["allowDependencyAdding"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can add dependencies.</summary>
		[Generated]
		public GanttEditingBuilder AllowDependencyAdding(JS value)
		{
			base.Options["allowDependencyAdding"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can delete dependencies.</summary>
		[Generated]
		public GanttEditingBuilder AllowDependencyDeleting(bool value)
		{
			base.Options["allowDependencyDeleting"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can delete dependencies.</summary>
		[Generated]
		public GanttEditingBuilder AllowDependencyDeleting(JS value)
		{
			base.Options["allowDependencyDeleting"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can update dependencies.</summary>
		[Generated]
		public GanttEditingBuilder AllowDependencyUpdating(bool value)
		{
			base.Options["allowDependencyUpdating"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can update dependencies.</summary>
		[Generated]
		public GanttEditingBuilder AllowDependencyUpdating(JS value)
		{
			base.Options["allowDependencyUpdating"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can add resources.</summary>
		[Generated]
		public GanttEditingBuilder AllowResourceAdding(bool value)
		{
			base.Options["allowResourceAdding"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can add resources.</summary>
		[Generated]
		public GanttEditingBuilder AllowResourceAdding(JS value)
		{
			base.Options["allowResourceAdding"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can delete resources.</summary>
		[Generated]
		public GanttEditingBuilder AllowResourceDeleting(bool value)
		{
			base.Options["allowResourceDeleting"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can delete resources.</summary>
		[Generated]
		public GanttEditingBuilder AllowResourceDeleting(JS value)
		{
			base.Options["allowResourceDeleting"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can update resources.</summary>
		[Generated]
		public GanttEditingBuilder AllowResourceUpdating(bool value)
		{
			base.Options["allowResourceUpdating"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can update resources.</summary>
		[Generated]
		public GanttEditingBuilder AllowResourceUpdating(JS value)
		{
			base.Options["allowResourceUpdating"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can add tasks.</summary>
		[Generated]
		public GanttEditingBuilder AllowTaskAdding(bool value)
		{
			base.Options["allowTaskAdding"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can add tasks.</summary>
		[Generated]
		public GanttEditingBuilder AllowTaskAdding(JS value)
		{
			base.Options["allowTaskAdding"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can delete tasks.</summary>
		[Generated]
		public GanttEditingBuilder AllowTaskDeleting(bool value)
		{
			base.Options["allowTaskDeleting"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can delete tasks.</summary>
		[Generated]
		public GanttEditingBuilder AllowTaskDeleting(JS value)
		{
			base.Options["allowTaskDeleting"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can update tasks.</summary>
		[Generated]
		public GanttEditingBuilder AllowTaskUpdating(bool value)
		{
			base.Options["allowTaskUpdating"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can update tasks.</summary>
		[Generated]
		public GanttEditingBuilder AllowTaskUpdating(JS value)
		{
			base.Options["allowTaskUpdating"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can edit tasks, resources and dependencies.</summary>
		[Generated]
		public GanttEditingBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can edit tasks, resources and dependencies.</summary>
		[Generated]
		public GanttEditingBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}
	}
}
