using System;

using LinqToDB_2_9_6.Mapping;

namespace Tests.Model
{
	public class TestIdentity
	{
		[Identity, PrimaryKey]
		//[SequenceName(ProviderName.PostgreSQL, "Seq")]
		//[SequenceName(ProviderName.Firebird,   "PersonID")]
		//[SequenceName("ID")]
		public int ID;
	}
}
