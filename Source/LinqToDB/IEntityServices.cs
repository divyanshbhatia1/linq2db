using System;

namespace LinqToDB_2_9_6
{
	public interface IEntityServices
	{
		/// <summary>
		/// Occurs when a new entity is created.
		/// </summary>
		Action<EntityCreatedEventArgs> OnEntityCreated { get; set; }
	}
}
