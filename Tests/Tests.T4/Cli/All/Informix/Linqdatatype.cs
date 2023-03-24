// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using IBM.Data.DB2Types;
using LinqToDB;
using LinqToDB.Mapping;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.Informix
{
	[Table("linqdatatypes")]
	public class Linqdatatype
	{
		[Column("id"            , DataType = DataType.Int32   , DbType = "INTEGER"                     , Length = 0                            )] public int?         Id             { get; set; } // INTEGER
		[Column("moneyvalue"    , DataType = DataType.Decimal , DbType = "DECIMAL(10,4)"               , Length = 0 , Precision = 10, Scale = 4)] public decimal?     Moneyvalue     { get; set; } // DECIMAL(10,4)
		[Column("datetimevalue" , DataType = DataType.DateTime, DbType = "DATETIME YEAR TO FRACTION(3)", Length = 0                            )] public DB2DateTime? Datetimevalue  { get; set; } // DATETIME YEAR TO FRACTION(3)
		[Column("datetimevalue2", DataType = DataType.DateTime, DbType = "DATETIME YEAR TO FRACTION(3)", Length = 0                            )] public DB2DateTime? Datetimevalue2 { get; set; } // DATETIME YEAR TO FRACTION(3)
		[Column("boolvalue"     , DataType = DataType.Boolean , DbType = "BOOLEAN"                     , Length = 0                            )] public bool?        Boolvalue      { get; set; } // BOOLEAN
		[Column("guidvalue"     , DataType = DataType.Char    , DbType = "CHAR(36)"                    , Length = 36                           )] public string?      Guidvalue      { get; set; } // CHAR(36)
		[Column("binaryvalue"   , DataType = DataType.Binary  , DbType = "BYTE"                        , Length = 0                            )] public byte[]?      Binaryvalue    { get; set; } // BYTE
		[Column("smallintvalue" , DataType = DataType.Int16   , DbType = "SMALLINT"                    , Length = 0                            )] public short?       Smallintvalue  { get; set; } // SMALLINT
		[Column("intvalue"      , DataType = DataType.Int32   , DbType = "INTEGER"                     , Length = 0                            )] public int?         Intvalue       { get; set; } // INTEGER
		[Column("bigintvalue"   , DataType = DataType.Int64   , DbType = "BIGINT"                      , Length = 0                            )] public long?        Bigintvalue    { get; set; } // BIGINT
		[Column("stringvalue"   , DataType = DataType.NVarChar, DbType = "NVARCHAR(50)"                , Length = 50                           )] public string?      Stringvalue    { get; set; } // NVARCHAR(50)
	}
}