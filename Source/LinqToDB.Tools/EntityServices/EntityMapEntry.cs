﻿using System;
using System.Threading;

namespace LinqToDB_2_9_6.Tools.EntityServices
{
	public class EntityMapEntry<T>
	{
		public T Entity { get; internal set; }

		private int _dbCount;
		public  int  DBCount => _dbCount;

		internal void IncrementDBCount()
		{
			Interlocked.Increment(ref _dbCount);
		}

		private int _cacheCount;
		public  int  CacheCount => _cacheCount;

		internal void IncrementCacheCount()
		{
			Interlocked.Increment(ref _cacheCount);
		}
	}
}
