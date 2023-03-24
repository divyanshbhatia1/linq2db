// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Mapping;
using LinqToDB.Tools.Comparers;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.Oracle
{
	[Table("t_entity")]
	public class TEntity : IEquatable<TEntity>
	{
		[Column("entity_id", DataType = DataType.Decimal , DbType = "NUMBER"                      , Length = 22, Scale     = 0, IsPrimaryKey = true)] public OracleDecimal EntityId { get; set; } // NUMBER
		[Column("time"     , DataType = DataType.DateTime, DbType = "DATE"                        , Length = 7                                     )] public OracleDate?   Time     { get; set; } // DATE
		[Column("duration" , DataType = DataType.Time    , DbType = "INTERVAL DAY(3) TO SECOND(2)", Length = 11, Precision = 3, Scale        = 2   )] public TimeSpan?     Duration { get; set; } // INTERVAL DAY(3) TO SECOND(2)

		#region IEquatable<T> support
		private static readonly IEqualityComparer<TEntity> _equalityComparer = ComparerBuilder.GetEqualityComparer<TEntity>(c => c.EntityId);

		public bool Equals(TEntity? other)
		{
			return _equalityComparer.Equals(this, other!);
		}

		public override int GetHashCode()
		{
			return _equalityComparer.GetHashCode(this);
		}

		public override bool Equals(object? obj)
		{
			return Equals(obj as TEntity);
		}
		#endregion
	}
}