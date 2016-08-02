using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Loans
{
    [XmlRoot("loans")]
    public class Loans
    {
        [XmlElement("loan")]
        public List<Loan> loans { get; set; }

    }
}
