using System;
using fortnitewinner.helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsFortniteWinner
{
    [TestClass]
    public class TestResultsFileReader
    {
        private ResultsFileReader fileReader ;

        [TestInitialize]
    public void InitializeTest()
        {
            fileReader = new ResultsFileReader();
        }

        [TestMethod]
        public void ReadsHeaderLine()
        {
            String actual = fileReader.ReadLine();
            Assert.IsTrue(actual.StartsWith("TeamName"));
        }

        [TestMethod]
        public void ReadsFirstDataLine()
        {
            GivenLinesHaveBeenRead(1);
            String actual = fileReader.ReadLine();
            Assert.IsTrue(actual.StartsWith("AlsAllStars"));
        }

        [TestMethod]
        public void DetectsEndOfDataReturningNull()
        {
            GivenLinesHaveBeenRead(7);

            String actual = fileReader.ReadLine();
            Assert.IsNull(actual);
        }

        private void GivenLinesHaveBeenRead(int numberOfLinesToRead)
        {
            for (int i = 0; i < numberOfLinesToRead; i++)
            {
                // read line and discard result
                fileReader.ReadLine();
            }
        }
    }
}
