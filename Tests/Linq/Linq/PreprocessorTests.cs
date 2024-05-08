using System;
using System.Linq;
using System.Linq.Expressions;

using LinqToDB_2_9_6.Data;
using LinqToDB_2_9_6.Expressions;
using LinqToDB_2_9_6.Linq;

using NUnit.Framework;

namespace Tests.Linq
{
	using Model;

	[TestFixture]
	public class PreprocessorTests : TestBase
	{
		class PostProcessorDataConnection : DataConnection, IExpressionPreprocessor
		{
			public PostProcessorDataConnection(string configurationString) : base(configurationString)
			{
			}

			public Expression ProcessExpression(Expression expression)
			{
				var result = expression.Transform(e =>
				{
					if (e.NodeType == ExpressionType.Constant)
					{
						var constant = (ConstantExpression) e;
						if (constant.Value is int)
						{
							return Expression.Constant((int) constant.Value + 1);
						}
					}
					return e;
				});

				return result;
			}
		}


		[Test]
		public void Test([DataSources(false)] string context)
		{
			using (var db = new PostProcessorDataConnection(context))
			{
				for (int i = 0; i < 3; i++)
				{
					var newId = db.GetTable<Parent>().Where(p => p.ParentID == 1).Select(p => p.ParentID).First();
					Assert.AreEqual(2, newId);
				}
			}
		}
	}
}
