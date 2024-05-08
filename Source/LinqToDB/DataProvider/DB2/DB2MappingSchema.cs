﻿using System;
using System.Text;

namespace LinqToDB_2_9_6.DataProvider.DB2
{
	using Mapping;
	using SqlQuery;
	using System.Data.Linq;

	public class DB2MappingSchema : MappingSchema
	{
		public DB2MappingSchema() : this(ProviderName.DB2)
		{
		}

		protected DB2MappingSchema(string configuration) : base(configuration)
		{
			SetValueToSqlConverter(typeof(Guid), (sb,dt,v) => ConvertGuidToSql(sb, (Guid)v));

			SetDataType(typeof(string), new SqlDataType(DataType.NVarChar, typeof(string), 255));

			SetValueToSqlConverter(typeof(String),   (sb,dt,v) => ConvertStringToSql  (sb, v.ToString()));
			SetValueToSqlConverter(typeof(Char),     (sb,dt,v) => ConvertCharToSql    (sb, (char)v));
			SetValueToSqlConverter(typeof(byte[]),   (sb,dt,v) => ConvertBinaryToSql  (sb, (byte[])v));
			SetValueToSqlConverter(typeof(Binary),   (sb,dt,v) => ConvertBinaryToSql  (sb, ((Binary)v).ToArray()));
		}

		static void ConvertBinaryToSql(StringBuilder stringBuilder, byte[] value)
		{
			stringBuilder.Append("BX'");

			foreach (var b in value)
				stringBuilder.Append(b.ToString("X2"));

			stringBuilder.Append("'");
		}

		static void AppendConversion(StringBuilder stringBuilder, int value)
		{
			stringBuilder
				.Append("chr(")
				.Append(value)
				.Append(")")
				;
		}

		static void ConvertStringToSql(StringBuilder stringBuilder, string value)
		{
			DataTools.ConvertStringToSql(stringBuilder, "||", null, AppendConversion, value, null);
		}

		static void ConvertCharToSql(StringBuilder stringBuilder, char value)
		{
			DataTools.ConvertCharToSql(stringBuilder, "'", AppendConversion, value);
		}

		internal static readonly DB2MappingSchema Instance = new DB2MappingSchema();

		static void ConvertGuidToSql(StringBuilder stringBuilder, Guid value)
		{
			var s = value.ToString("N");

			stringBuilder
				.Append("Cast(x'")
				.Append(s.Substring( 6,  2))
				.Append(s.Substring( 4,  2))
				.Append(s.Substring( 2,  2))
				.Append(s.Substring( 0,  2))
				.Append(s.Substring(10,  2))
				.Append(s.Substring( 8,  2))
				.Append(s.Substring(14,  2))
				.Append(s.Substring(12,  2))
				.Append(s.Substring(16, 16))
				.Append("' as char(16) for bit data)")
				;
		}
	}

	public class DB2zOSMappingSchema : MappingSchema
	{
		public DB2zOSMappingSchema()
			: base(ProviderName.DB2zOS, DB2MappingSchema.Instance)
		{
		}
	}

	public class DB2LUWMappingSchema : MappingSchema
	{
		public DB2LUWMappingSchema()
			: base(ProviderName.DB2LUW, DB2MappingSchema.Instance)
		{
		}
	}
}
