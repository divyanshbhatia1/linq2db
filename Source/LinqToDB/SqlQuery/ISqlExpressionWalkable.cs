using System;

namespace LinqToDB_2_9_6.SqlQuery
{
	public class WalkOptions
	{
		public WalkOptions()
		{
		}

		public WalkOptions(bool skipColumns)
		{
			SkipColumns = skipColumns;
		}

		public bool SkipColumns;
		public bool ProcessParent;
	}

	public interface ISqlExpressionWalkable
	{
		ISqlExpression Walk(WalkOptions options, Func<ISqlExpression,ISqlExpression> func);
	}
}
