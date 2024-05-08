using System;
using System.Collections.Generic;

namespace LinqToDB_2_9_6.SqlQuery
{
	public interface ICloneableElement
	{
		ICloneableElement Clone(Dictionary<ICloneableElement,ICloneableElement> objectTree, Predicate<ICloneableElement> doClone);
	}
}
