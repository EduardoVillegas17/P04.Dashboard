using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class Products
    {
        public int Id { get; set; }
        public int ProductsCode { get; set; }
        public string ProductsName { get; set; }
        public String Description { get; set; }
        public int Quantity { get; set; }
        public string Price { get; set; }
        public int SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }
    }
}