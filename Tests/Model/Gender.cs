using System;

using LinqToDB_2_9_6.Mapping;

namespace Tests.Model
{
	public enum Gender
	{
		[MapValue("M")] Male,
		[MapValue("F")] Female,
		[MapValue("U")] Unknown,
		[MapValue("O")] Other,
	}
}
