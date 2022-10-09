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
	public class PlayingFieldTests
	{
		[TestMethod()]
		public void CreateNotRandomFieldTest()
		{
			var expected = new bool[,] {
				{ false, false, false },
				{ false, false, false },
				{ false, false, false } };

			var actual = new PlayingField(3, false);

			CollectionAssert.AreEquivalent(expected, actual.Field);
		}

		[TestMethod()]
		public void CreateRandomFieldTest()
		{
			var notExpected = new bool[,] {
				{ false, false, false },
				{ false, false, false },
				{ false, false, false } };

			var actual = new PlayingField(3, true);

			CollectionAssert.AreNotEquivalent(notExpected, actual.Field);
		}

		[TestMethod()]
		public void ChangeFieldTest()
		{
			var expected = new bool[,] {
				{ true, true, true },
				{ false, true, false },
				{ false, true, false } };

			var actual = new PlayingField(3, false);
			actual.ChangeField(1, 0);

			CollectionAssert.AreEquivalent(expected, actual.Field);
		}
	}
}