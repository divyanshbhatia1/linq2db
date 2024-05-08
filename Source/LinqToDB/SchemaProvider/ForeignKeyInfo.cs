using System;

namespace LinqToDB_2_9_6.SchemaProvider
{
	public class ForeignKeyInfo
	{
		public string Name;
		public string ThisTableID;
		public string ThisColumn;
		public string OtherTableID;
		public string OtherColumn;
		public int    Ordinal;
	}
}
