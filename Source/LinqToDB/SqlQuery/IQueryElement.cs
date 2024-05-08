﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinqToDB_2_9_6.SqlQuery
{
	public interface IQueryElement //: ICloneableElement
	{
		QueryElementType ElementType { get; }
		StringBuilder    ToString (StringBuilder sb, Dictionary<IQueryElement,IQueryElement> dic);
	}
}
