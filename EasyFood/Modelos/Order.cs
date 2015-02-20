using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyFood.Modelos
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public double TotalPrice { get; set; }
        public virtual ICollection<PlateOrder> Plates { get; set; }

        public Restaurant Restaurant { get; set; }
        public User User { get; set; }


    }
}