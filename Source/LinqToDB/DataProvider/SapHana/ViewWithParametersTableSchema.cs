using System;
using System.Collections.Generic;

namespace LinqToDB_2_9_6.DataProvider.SapHana
{
	using SchemaProvider;


	public class ViewWithParametersTableSchema : TableSchema
	{
		public ViewWithParametersTableSchema()
		{
			IsProviderSpecific = true;
		}

		public List<ParameterSchema> Parameters { get; set; }
	}
}
