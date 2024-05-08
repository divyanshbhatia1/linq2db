﻿using System;
using System.Diagnostics;

namespace LinqToDB_2_9_6.SchemaProvider
{
	[DebuggerDisplay("TableID = {TableID}, PrimaryKeyName = {PrimaryKeyName}, ColumnName = {ColumnName}, Ordinal = {Ordinal}")]
	public class PrimaryKeyInfo
	{
		public string TableID;
		public string PrimaryKeyName;
		public string ColumnName;
		public int    Ordinal;
	}
}
