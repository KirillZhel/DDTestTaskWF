using Microsoft.VisualStudio.TestTools.UnitTesting;
using DDTestTaskWF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTestTaskWF.Tests
{
	[TestClass()]
	public class FieldInspectorTests
	{
		[TestMethod()]
		public void CheckTest()
		{
			bool[,] field = {
				{ true, false },
				{ false, true }
			};

			var actual = FieldInspector.Check(field);

			Assert.IsFalse(actual);
		}

		[TestMethod()]
		public void CheckAllTrueTest()
		{
			bool[,] field = {
				{ true, true },
				{ true, true }
			};

			var actual = FieldInspector.Check(field);

			Assert.IsTrue(actual);
		}

		[TestMethod()]
		public void CheckAllFalseTest()
		{
			bool[,] field = {
				{ false, false },
				{ false, false }
			};

			var actual = FieldInspector.Check(field);

			Assert.IsTrue(actual);
		}
	}
}