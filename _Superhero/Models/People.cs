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
        [Required]
        [StringLength(255)]
            public string Name { get; set; }
                public int Age { get; set; }
            public string alterEgo { get; set; }
            public string primeryAbility { get; set; }
            public string secondaryAbility { get; set; }
            public string catchphrase { get; set; }
    }
}