﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public int SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public String Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
    }
}