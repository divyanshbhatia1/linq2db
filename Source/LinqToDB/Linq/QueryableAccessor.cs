using System;
using System.Linq;
using System.Linq.Expressions;

namespace LinqToDB_2_9_6.Linq
{
	class QueryableAccessor
	{
		public IQueryable                  Queryable;
		public Func<Expression,IQueryable> Accessor;
	}
}
