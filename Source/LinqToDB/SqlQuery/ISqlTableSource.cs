using System;
using System.Collections.Generic;

namespace LinqToDB_2_9_6.SqlQuery
{
	public interface ISqlTableSource : ISqlExpression
	{
		SqlField              All          { get; }
		int                   SourceID     { get; }
		SqlTableType          SqlTableType { get; }
		IList<ISqlExpression> GetKeys(bool allIfEmpty);
	}
}
