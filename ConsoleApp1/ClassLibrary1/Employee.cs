﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<JobTitle> JobTitles { get; set; }
    
    }
}
