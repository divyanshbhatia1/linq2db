// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Fluent.SqlServerNorthwind
{
	public class Employee
	{
		public int       EmployeeId      { get; set; } // int
		public string    LastName        { get; set; } = null!; // nvarchar(20)
		public string    FirstName       { get; set; } = null!; // nvarchar(10)
		public string?   Title           { get; set; } // nvarchar(30)
		public string?   TitleOfCourtesy { get; set; } // nvarchar(25)
		public DateTime? BirthDate       { get; set; } // datetime
		public DateTime? HireDate        { get; set; } // datetime
		public string?   Address         { get; set; } // nvarchar(60)
		public string?   City            { get; set; } // nvarchar(15)
		public string?   Region          { get; set; } // nvarchar(15)
		public string?   PostalCode      { get; set; } // nvarchar(10)
		public string?   Country         { get; set; } // nvarchar(15)
		public string?   HomePhone       { get; set; } // nvarchar(24)
		public string?   Extension       { get; set; } // nvarchar(4)
		public byte[]?   Photo           { get; set; } // image
		public string?   Notes           { get; set; } // ntext
		public int?      ReportsTo       { get; set; } // int
		public string?   PhotoPath       { get; set; } // nvarchar(255)

		#region Associations
		/// <summary>
		/// FK_Employees_Employees
		/// </summary>
		public Employee? Employees { get; set; }

		/// <summary>
		/// FK_Employees_Employees backreference
		/// </summary>
		public IEnumerable<Employee> Employees1 { get; set; } = null!;

		/// <summary>
		/// FK_EmployeeTerritories_Employees backreference
		/// </summary>
		public IEnumerable<EmployeeTerritory> EmployeeTerritories { get; set; } = null!;

		/// <summary>
		/// FK_Orders_Employees backreference
		/// </summary>
		public IEnumerable<Order> Orders { get; set; } = null!;
		#endregion
	}
}
