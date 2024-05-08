using System;

namespace LinqToDB_2_9_6.SqlQuery
{
	public interface ISqlPredicate : IQueryElement, ISqlExpressionWalkable, ICloneableElement
	{
		bool CanBeNull  { get; }
		int  Precedence { get; }
	}
}
