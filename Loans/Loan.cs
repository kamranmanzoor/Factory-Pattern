using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Loans
{    
    public class Loan
    {
        [XmlElement("customerid")]
        public string CustomerId { get; set; }

        [XmlElement("amount")]
        public string Amount { get; set; }

        [XmlElement("interestrate")]
        public string InterestRate { get; set; }
    }
}
