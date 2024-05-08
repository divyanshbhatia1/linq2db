extern alias MySqlData;

using System;
using System.Linq;

using LinqToDB_2_9_6;

using MySqlData::MySql.Data.MySqlClient;

using NUnit.Framework;

namespace Tests.Exceptions
{
	using Model;

	[TestFixture]
	public class DataExceptionTests : TestBase
	{
		[Test]
		public void ParameterPrefixTest([IncludeDataSources(TestProvName.AllMySqlData)] string context)
		{
			try
			{
				using (var db = LinqToDB_2_9_6.DataProvider.MySql.MySqlTools.CreateDataConnection(
					"Server=DBHost;Port=3306;Database=nodatabase;Uid=bltoolkit;Pwd=TestPassword;"))
				{
					db.GetTable<Person>().ToList();
				}
			}
			catch (MySqlException ex)
			{
				var number = ex.Number;
			}
		}
	}
}
