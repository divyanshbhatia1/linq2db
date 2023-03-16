// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Mapping;
using LinqToDB.Tools.Comparers;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.SqlServer
{
	[Table("InheritanceChild")]
	public class InheritanceChild : IEquatable<InheritanceChild>
	{
		[Column("InheritanceChildId" , DataType = LinqToDB.DataType.Int32   , DbType = "int"         , IsPrimaryKey = true)] public SqlInt32   InheritanceChildId  { get; set; } // int
		[Column("InheritanceParentId", DataType = LinqToDB.DataType.Int32   , DbType = "int"                              )] public SqlInt32   InheritanceParentId { get; set; } // int
		[Column("TypeDiscriminator"  , DataType = LinqToDB.DataType.Int32   , DbType = "int"                              )] public SqlInt32?  TypeDiscriminator   { get; set; } // int
		[Column("Name"               , DataType = LinqToDB.DataType.NVarChar, DbType = "nvarchar(50)", Length       = 50  )] public SqlString? Name                { get; set; } // nvarchar(50)

		#region IEquatable<T> support
		private static readonly IEqualityComparer<InheritanceChild> _equalityComparer = ComparerBuilder.GetEqualityComparer<InheritanceChild>(c => c.InheritanceChildId);

		public bool Equals(InheritanceChild? other)
		{
			return _equalityComparer.Equals(this, other!);
		}

		public override int GetHashCode()
		{
			return _equalityComparer.GetHashCode(this);
		}

		public override bool Equals(object? obj)
		{
			return Equals(obj as InheritanceChild);
		}
		#endregion
	}
}
