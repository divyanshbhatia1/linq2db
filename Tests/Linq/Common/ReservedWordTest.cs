﻿using LinqToDB_2_9_6;
using LinqToDB_2_9_6.SqlQuery;
using NUnit.Framework;

namespace Tests.Common
{
	[TestFixture]
	public class ReservedWordTest
	{
		[Test]
		public void Test([Values("", ProviderName.PostgreSQL, ProviderName.Oracle)]string providerName)
		{
			Assert.True(ReservedWords.IsReserved("select", providerName));
			Assert.True(ReservedWords.IsReserved("SELECT", providerName));
			Assert.True(ReservedWords.IsReserved("Select", providerName));
		}
	}
}
