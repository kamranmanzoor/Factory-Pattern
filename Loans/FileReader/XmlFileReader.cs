using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;

namespace Loans
{
    public class XmlFileReader : IFileReader
    {
        private string _filePath;
        private string _fileName;
        private Loans _loans;

        public XmlFileReader(string path, string fileName)
        {
            _filePath = path;
            _fileName = fileName;
        }

        public Loans Read()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Loans));

            using (FileStream stream = File.OpenRead(_filePath + _fileName))
            {
                _loans = (Loans)serializer.Deserialize(stream);
            }

            return _loans;
        }
    }
}
