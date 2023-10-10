using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary1
{
    public class JobTitle
    {
        public string JobName { get; set; }
        public string Duration { get; set; }
    
    public override string ToString()
    {
        return JobName + " " + Duration;
    }

    }
}
