using System;
using System.Collections.Generic;

namespace LinqToDB_2_9_6.DataProvider.Sybase
{
	using Data;

	class SybaseBulkCopy : BasicBulkCopy
	{
		protected override BulkCopyRowsCopied MultipleRowsCopy<T>(
			ITable<T> table, BulkCopyOptions options, IEnumerable<T> source)
		{
			return MultipleRowsCopy2(table, options, source, "");
		}
	}
}
