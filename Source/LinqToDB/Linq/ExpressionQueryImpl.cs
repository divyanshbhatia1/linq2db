using System;
using System.Linq.Expressions;

namespace LinqToDB_2_9_6.Linq
{
	class ExpressionQueryImpl<T> : ExpressionQuery<T>
	{
		public ExpressionQueryImpl(IDataContext dataContext, Expression expression)
		{
			Init(dataContext, expression);
		}

		public override string ToString()
		{
			return SqlText;
		}
	}
}
