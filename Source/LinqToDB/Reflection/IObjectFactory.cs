using System;

namespace LinqToDB_2_9_6.Reflection
{
	public interface IObjectFactory
	{
		object CreateInstance(TypeAccessor typeAccessor);
	}
}
