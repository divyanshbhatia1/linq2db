﻿using System;

namespace LinqToDB_2_9_6.SqlQuery
{
	[Flags]
	public enum SetOperation
	{
		Union        = 0x1,
		UnionAll     = 0x2,
		Except       = 0x3,
		ExceptAll    = 0x4,
		Intersect    = 0x8,
		IntersectAll = 0xA
	}
}
