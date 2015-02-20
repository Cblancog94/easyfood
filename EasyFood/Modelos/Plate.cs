using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyFood.Modelos
{
    public class Plate
    {
        [Key]
        public int PlateID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public virtual ICollection<PlateOrder> Orders { get; set; }

        public Restaurant Restaurant { get; set; }
    }
}