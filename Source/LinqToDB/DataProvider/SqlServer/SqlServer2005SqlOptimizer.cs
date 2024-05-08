﻿using System;

namespace LinqToDB_2_9_6.DataProvider.SqlServer
{
	using SqlProvider;
	using SqlQuery;

	class SqlServer2005SqlOptimizer : SqlServerSqlOptimizer
	{
		public SqlServer2005SqlOptimizer(SqlProviderFlags sqlProviderFlags) : base(sqlProviderFlags)
		{
		}

		public override ISqlExpression ConvertExpression(ISqlExpression expr)
		{
			expr = base.ConvertExpression(expr);

			if (expr is SqlFunction)
				return ConvertConvertFunction((SqlFunction)expr);

			return expr;
		}
	}
}
