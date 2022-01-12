using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwaProject2.Shared
{
    public class Product
    {
        [Key]
        public int? inId { get; set; }
        public string stName { get; set; }
        public decimal? dcPrice { get; set; }
        public string stDescription { get; set; }
        public string stDiscount { get; set; }
        public int? inQuantity { get; set; }
        public bool flgOutOfStock { get; set; }
    }
}
