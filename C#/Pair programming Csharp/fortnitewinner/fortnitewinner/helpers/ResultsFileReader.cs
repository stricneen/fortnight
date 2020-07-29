using System;
using System.IO;
using System.Reflection;
using fortnitewinner.interfaces;

namespace fortnitewinner.helpers
{
    public class ResultsFileReader : IResultsFileReader, IDisposable
    {
        private readonly string dataPath =         
            Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"data\fortniteresults.txt");
        private readonly StreamReader streamReader = null;

        public ResultsFileReader()
        {
            if (File.Exists(dataPath))
            {
                streamReader = new StreamReader(dataPath);
            }
        }

        public string ReadLine()
        {
            try
            {
                return this.streamReader.Peek() == -1 ? null : this.streamReader.ReadLine();
            }
            catch (Exception e)
            {
                throw new IOException(message: $"Could not read a data line: {e.Message}");
            }
        }

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue && disposing && streamReader != null)
            {
                this.streamReader.Dispose();
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
