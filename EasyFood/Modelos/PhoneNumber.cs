using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyFood.Modelos
{
    public class PhoneNumber
    {
        [Key]
        public int PhoneNumberID { get; set; }
        public string Cellphone { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}