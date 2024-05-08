using System.Diagnostics;

namespace LinqToDB_2_9_6.SchemaProvider
{
	[DebuggerDisplay("CatalogName = {CatalogName}, SchemaName = {SchemaName}, TableName = {TableName}, IsDefaultSchema = {IsDefaultSchema}, IsView = {IsView}, Description = {Description}")]
	public class TableInfo
	{
		public string TableID;
		public string CatalogName;
		public string SchemaName;
		public string TableName;
		public string Description;
		public bool   IsDefaultSchema;
		public bool   IsView;
		public bool   IsProviderSpecific;
	}
}
