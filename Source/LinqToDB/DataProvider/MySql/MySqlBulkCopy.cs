using System;
using System.Collections.Generic;

namespace LinqToDB_2_9_6.DataProvider.MySql
{
	using Data;

	class MySqlBulkCopy : BasicBulkCopy
	{
		protected override BulkCopyRowsCopied MultipleRowsCopy<T>(
			ITable<T> table, BulkCopyOptions options, IEnumerable<T> source)
		{
			return MultipleRowsCopy1(table, options, source);
		}
	}
}
