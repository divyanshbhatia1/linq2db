using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LinqToDB_2_9_6.Linq.Builder
{
	public class SequenceConvertInfo
	{
		public ParameterExpression       Parameter;
		public Expression                Expression;
		public List<SequenceConvertPath> ExpressionsToReplace;
	}
}
