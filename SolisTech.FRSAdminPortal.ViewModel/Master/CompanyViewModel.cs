﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolisTech.FRSAdminPortal.ViewModel
{
    public class CompanyViewModel
    {
        public int Id { get; set; }
        public string CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string DatabaseConnectionString { get; set; }
    }
}
