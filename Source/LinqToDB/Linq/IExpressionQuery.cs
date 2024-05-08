using System;
using System.Linq.Expressions;

namespace LinqToDB_2_9_6.Linq
{
	public interface IExpressionQuery
	{
		Expression   Expression  { get; }
		string       SqlText     { get; }
		IDataContext DataContext { get; }
	}
}
