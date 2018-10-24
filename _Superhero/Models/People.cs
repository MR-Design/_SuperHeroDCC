using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _Superhero.Models
{
    public class People
    {
             [Key]
            public int ID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }      
    }
}