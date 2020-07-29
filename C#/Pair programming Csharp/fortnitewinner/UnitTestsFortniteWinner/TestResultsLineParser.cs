using System;
using fortnitewinner.helpers;
using fortnitewinner.interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsFortniteWinner
{
    [TestClass]
    public class TestResultsLineParser
    {
        private static readonly string EXAMPLE_RESULTS_LINE =
            "AlsAllStars                  4                2               5";

        private ResultsLineParser parser;

        public TestResultsLineParser()
        {
            parser = new ResultsLineParser(EXAMPLE_RESULTS_LINE);
        }

        [TestMethod]
        public void ExtractsTeamName()
        {
            Assert.AreEqual("AlsAllStars", parser.GetTeamName());
        }

    }
}
