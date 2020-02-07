using System;
using fortnitewinner.helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsFortniteWinner
{
    [TestClass]
    public class TestResultsLineParser
    {
        private static readonly string EXAMPLE_RESULTS_LINE =
            "AlsAllStars                  4                2               5";

        private ResultsLineParser parser ;

        [TestInitialize]
        public void InitializeTest()
        {
            parser = new ResultsLineParser(EXAMPLE_RESULTS_LINE);
        }

        [TestMethod]
        public void ExtractsTeamName()
        {
            string actual = parser.GetTeamName();
            Assert.AreEqual("AlsAllStars", actual);
        }

    }
}
