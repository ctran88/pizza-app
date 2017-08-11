using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pizza_App.Models
{
    public class PizzaType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        [DataType(DataType.Currency)]
        public float Price { get; set; }
    }
}