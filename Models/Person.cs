using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public class Person
    {
        public int ID { get; set; }
        [Required]
        public string First { get; set; }
        [Required]
        [StringLength(15)]
        public string LastName { get; set; }
        public DateTime BithDay { get; set; }  
        }
}