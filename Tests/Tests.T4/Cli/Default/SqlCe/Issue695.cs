// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Default.SqlCe
{
	[Table("Issue695")]
	public class Issue695
	{
		[Column("ID"         , IsPrimaryKey = true)] public int Id          { get; set; } // int
		[Column("UniqueValue"                     )] public int UniqueValue { get; set; } // int

		#region Associations
		/// <summary>
		/// FK_Issue695_Parent
		/// </summary>
		[Association(CanBeNull = false, ThisKey = nameof(Id), OtherKey = nameof(Issue695Parent.Id))]
		public Issue695Parent Parent { get; set; } = null!;
		#endregion
	}
}
