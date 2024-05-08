using System;
using System.Collections.Specialized;

using JetBrains.Annotations;

namespace LinqToDB_2_9_6.DataProvider.Informix
{
	using System.Collections.Generic;
	using Configuration;

	[UsedImplicitly]
	class InformixFactory : IDataProviderFactory
	{
		IDataProvider IDataProviderFactory.GetDataProvider(IEnumerable<NamedValue> attributes)
		{
			return new InformixDataProvider();
		}
	}
}
