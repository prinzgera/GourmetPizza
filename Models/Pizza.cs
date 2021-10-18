using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GourmetPizza.Models
{
    public class Pizza
    {
        [Key]
        [Required]
        public int PizzaType { get; set; }

        [Required]
        public string PizzaName { get; set; }

        [Required]
        public float Price { get; set; }


        public string ImageName { get; set; }
    }
}
