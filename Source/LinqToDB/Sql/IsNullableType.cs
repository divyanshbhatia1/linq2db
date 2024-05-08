using System;

namespace LinqToDB_2_9_6
{
	public static partial class Sql
	{
		public enum IsNullableType
		{
			Undefined = 0,
			Nullable,
			NotNullable,
			IfAnyParameterNullable,
			SameAsFirstParameter,
			SameAsSecondParameter,
			SameAsThirdParameter,
			SameAsLastParameter,
		}
	}
}
