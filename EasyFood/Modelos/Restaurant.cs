using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyFood.Modelos
{
    public class Restaurant
    {
        [Key]
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string RIF { get; set; }
        public double DeliveryRate { get; set; }

        public User Manager { get; set; }

        public virtual ICollection<PhoneNumber> Numbers { get; set; }
        public virtual ICollection<Plate> Plates { get; set; }
    }
}