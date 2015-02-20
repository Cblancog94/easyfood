using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyFood.Modelos
{
    public class PlateOrder
    {
        [Key]
        public int PlateOrderID { get; set; }
        public Plate Plate { get; set; }
        public double PlatePrice { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }
    }
}