// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Mapping;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.Access.Both
{
	[Table("Parent")]
	public class Parent
	{
		[Column("ParentID", DataType = DataType.Int32, DbType = "Long")] public int? ParentId { get; set; } // Long
		[Column("Value1"  , DataType = DataType.Int32, DbType = "Long")] public int? Value1   { get; set; } // Long
	}
}
