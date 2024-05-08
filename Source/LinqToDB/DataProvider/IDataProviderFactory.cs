using System.Collections.Generic;
using LinqToDB_2_9_6.Configuration;

namespace LinqToDB_2_9_6.DataProvider
{

	public interface IDataProviderFactory
	{
		IDataProvider GetDataProvider (IEnumerable<NamedValue> attributes);
	}
}
