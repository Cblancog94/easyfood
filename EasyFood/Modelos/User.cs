using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyFood.Modelos
{
    public class User
    {
            [Key]
            public int UserID { get; set;}
            public string Name {get; set;}
            public string Lastname {get; set;}
            public string Username {get; set;}
            public string Email { get; set; }
            public string Number { get; set; }

            public UserType UserType { get; set; }
            public virtual ICollection<Order> Orders { get; set; }
           
    }
}