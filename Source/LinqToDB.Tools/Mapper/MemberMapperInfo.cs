using System;
using System.Linq.Expressions;

using JetBrains.Annotations;

namespace LinqToDB_2_9_6.Tools.Mapper
{
	public class MemberMapperInfo
	{
		[NotNull] public LambdaExpression ToMember { get; set; }
		[NotNull] public LambdaExpression Setter   { get; set; }
	}
}
