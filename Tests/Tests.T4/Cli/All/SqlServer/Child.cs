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
	[Table("Child")]
	public class Child : IEquatable<Child>
	{
		[Column("ParentID", DataType = LinqToDB.DataType.Int32, DbType = "int"                                                                                  )] public SqlInt32? ParentId { get; set; } // int
		/// <summary>
		/// This ChildID column
		/// </summary>
		[Column("ChildID" , DataType = LinqToDB.DataType.Int32, DbType = "int"                                                                                  )] public SqlInt32? ChildId  { get; set; } // int
		[Column("_ID"     , DataType = LinqToDB.DataType.Int32, DbType = "int", IsPrimaryKey = true, IsIdentity = true, SkipOnInsert = true, SkipOnUpdate = true)] public SqlInt32  Id       { get; set; } // int

		#region IEquatable<T> support
		private static readonly IEqualityComparer<Child> _equalityComparer = ComparerBuilder.GetEqualityComparer<Child>(c => c.Id);

		public bool Equals(Child? other)
		{
			return _equalityComparer.Equals(this, other!);
		}

		public override int GetHashCode()
		{
			return _equalityComparer.GetHashCode(this);
		}

		public override bool Equals(object? obj)
		{
			return Equals(obj as Child);
		}
		#endregion
	}
}
