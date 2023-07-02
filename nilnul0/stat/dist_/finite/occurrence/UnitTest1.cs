using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul._stat_._TEST_.dist_.finite_.occurrence
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var t = nilnul.stat.dist_.finite._EntropyX.Entropy_ofAssumeOccurrences(
				5,9
			);
			Debug.WriteLine(t);
		}
	}
}
