using System;

namespace LinqToDB_2_9_6.DataProvider.SapHana
{
	using Data;
	using SchemaProvider;

	public class GetHanaSchemaOptions: GetSchemaOptions
	{
		public Func<ProcedureSchema, DataParameter[]> GetStoredProcedureParameters = schema => null;
		public bool ThrowExceptionIfCalculationViewsNotAuthorized = false;
	}
}
