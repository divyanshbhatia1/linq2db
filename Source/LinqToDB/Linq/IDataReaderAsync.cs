using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace LinqToDB_2_9_6.Linq
{
	public interface IDataReaderAsync : IDisposable
	{
		IDataReader DataReader { get; }
		Task<bool>  ReadAsync(CancellationToken cancellationToken);
	}
}
