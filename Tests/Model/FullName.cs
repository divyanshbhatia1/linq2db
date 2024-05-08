using System;

using LinqToDB_2_9_6.Mapping;

namespace Tests.Model
{
	public class FullName
	{
		public string FirstName { get; set; }
		public string LastName;
		[Nullable]
		public string MiddleName;
	}
}