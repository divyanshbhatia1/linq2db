using System;
using System.Linq.Expressions;

namespace LinqToDB_2_9_6.Linq
{
	public interface IExpressionPreprocessor
	{
		Expression ProcessExpression(Expression expression);
	}
}