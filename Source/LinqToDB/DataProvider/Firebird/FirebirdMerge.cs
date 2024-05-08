using System;
using System.Collections.Generic;

namespace LinqToDB_2_9_6.DataProvider.Firebird
{
	using Data;

	class FirebirdMerge : BasicMerge
	{
		protected override bool BuildUsing<T>(DataConnection dataConnection, IEnumerable<T> source)
		{
			return BuildUsing2(dataConnection, source, null, "FROM rdb$database");
		}
	}
}
