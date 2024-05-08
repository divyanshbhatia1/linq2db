﻿using System;
using System.Diagnostics;
using System.Linq.Expressions;

using JetBrains.Annotations;

namespace LinqToDB_2_9_6.Linq.Builder
{
	[DebuggerDisplay("Path = {Path}, Expr = {Expr}, Level = {Level}")]
	public class SequenceConvertPath
	{
		[NotNull] public Expression Path;
		[NotNull] public Expression Expr;
		          public int        Level;
	}
}
