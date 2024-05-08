using System;

namespace LinqToDB_2_9_6.SqlQuery
{
	using Mapping;

	public class SqlTable<T> : SqlTable
	{
		public SqlTable()
			: base(typeof(T))
		{
		}

		public SqlTable(MappingSchema mappingSchema)
			: base(mappingSchema, typeof(T))
		{
		}
	}
}
