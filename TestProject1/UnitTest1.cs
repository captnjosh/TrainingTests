using System;
using System.Linq;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
	[TestClass]
	public class UnitTest1
	{
		private const string testShort = "hello!";
		private const string testShortResult = "!olleh";

		private static readonly Random random = new();

		private string testLong;

		public static string RandomString(int length)
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars, length)
				.Select(s => s[random.Next(s.Length)]).ToArray());
		}

		[TestInitialize]
		public void Init()
		{
			testLong = RandomString(1000);
		}

		[TestMethod]
		public void TestMethod1()
		{
			var test = new Class1();

			var result = test.MyReverse(testShort);
			Assert.AreEqual(testShortResult, result);

			result = test.MyReverse(testLong);
			Assert.AreEqual(result, result);

			//result = test.MyReverse("");
			//Assert.AreEqual("", result);

			//result = test.MyReverse(null);
			//Assert.AreEqual("", result);
		}

		[TestMethod]
		public void TestMethod2()
		{
			var test = new Class1();

			var result2 = test.MyReverse2(testShort);
			Assert.AreEqual(testShortResult, result2);

			result2 = test.MyReverse2(testLong);
			Assert.AreEqual(result2, result2);
		}
	}
}