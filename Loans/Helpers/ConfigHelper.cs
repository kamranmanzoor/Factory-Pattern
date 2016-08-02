using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Loans
{
    public static class ConfigHelper
    {
        public static string GetFilePath()
        {
            return ConfigurationManager.AppSettings["FilePath"];
        }
    }
}
