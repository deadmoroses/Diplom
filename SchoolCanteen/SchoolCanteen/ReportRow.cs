using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCanteen
{
    public class ReportRow
    {
        public ReportRow(string a, string b, string c)
        {
            A = a;
            B = b;
            C = c;
        }
        public ReportRow()
        {
            A = "";
            B = "";
            C = "";
        }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
    }
}
