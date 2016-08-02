using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Loans
{
    public class CsvFileReader : IFileReader
    {
        private string _filePath;
        private string _fileName;
        private Loans _loans;
        private string[] _headerLine;

        public CsvFileReader(string path, string filename)
        {
            _filePath = path;
            _fileName = filename;
            _loans = new Loans{ loans = new List<Loan>()};
        }

        public Loans Read()
        {
            using (StreamReader sr = new StreamReader(_filePath + _fileName))
            {
                _headerLine = sr.ReadLine().Split(',').ToArray();

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var lineValues = line.Split(',').ToArray();

                    _loans.loans.Add(new Loan
                    {
                        CustomerId = lineValues[0],
                        Amount = lineValues[1],
                        InterestRate = lineValues[2]
                    });
                }
            }

            return _loans;
        }
    }
}
