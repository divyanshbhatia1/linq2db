using System;
using System.Collections.Generic;

namespace LinqToDB_2_9_6.Linq
{
	using SqlQuery;

	public interface IQueryContext
	{
		SqlStatement   Statement   { get; }
		object         Context     { get; set; }
		List<string>   QueryHints  { get; set; }

		SqlParameter[] GetParameters();
	}
}
