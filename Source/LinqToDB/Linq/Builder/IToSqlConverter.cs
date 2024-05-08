using System;
using System.Linq.Expressions;

using LinqToDB_2_9_6.SqlQuery;

namespace LinqToDB_2_9_6.Linq.Builder
{
	public interface IToSqlConverter
	{
		ISqlExpression ToSql(Expression expression);
	}
}
