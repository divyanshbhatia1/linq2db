// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------


#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Fluent.Access.Both
{
	public class Patient
	{
		public int    PersonId  { get; set; } // Long
		public string Diagnosis { get; set; } = null!; // VarChar(255)

		#region Associations
		/// <summary>
		/// PersonPatient
		/// </summary>
		public Person PersonPatient { get; set; } = null!;
		#endregion
	}
}
