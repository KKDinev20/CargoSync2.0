﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoSync.DataAccess.Models
{
    public class Revenue
    {
        public int RevenueID { get; set; }
        public decimal Amount { get; set; }
        public string Month { get; set; }
    }
}
