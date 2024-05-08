using System;
using System.Linq.Expressions;

namespace LinqToDB_2_9_6.Linq
{
	using Mapping;

	public interface IExpressionInfo
	{
		LambdaExpression GetExpression(MappingSchema mappingSchema);
	}
}
