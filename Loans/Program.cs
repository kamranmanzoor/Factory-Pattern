using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Loans
{
    class Program
    {
        static void Main(string[] args)
        { 
            var filePath = ConfigHelper.GetFilePath();
            IFileReader _csvfileReader = new CsvFileReader(filePath, "loans.csv");
            var csvLoans = _csvfileReader.Read();          

            ICalculateTotal csvtotal = new CalculateTotal(csvLoans);
            var csvTotalLent = csvtotal.GetTotalLent();
            var csvTotalReturn = csvtotal.GetTotalReturn();

            IPrint print = new Print(csvLoans);
            print.PrintHeader();
            print.PrintBody();
            print.PrintTotal(csvTotalLent,csvTotalReturn);

            Console.ReadKey();


            //Read and print from xml file

            IFileReader _xmlfileRader = new XmlFileReader(filePath, "loans.xml");
            var xmlLoans = _xmlfileRader.Read();


            ICalculateTotal xmltotal = new CalculateTotal(csvLoans);
            var xmlTotalLent = xmltotal.GetTotalLent();
            var xmlTotalReturn = xmltotal.GetTotalReturn();

            IPrint printxml = new Print(xmlLoans);
            print.PrintHeader();
            print.PrintBody();
            print.PrintTotal(xmlTotalLent, xmlTotalReturn);

            Console.ReadKey();

        }       
    }   
}
