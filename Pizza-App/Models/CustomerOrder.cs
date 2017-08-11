using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pizza_App.Models
{
    public class CustomerOrder
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        public PizzaType PizzaType { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        [Required]
        public DateTime DeliveryDate { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public float TotalCost
        {
            get
            {
                return Quantity * PizzaType.Price;
            }

            set
            {

            }
        }
    }
}
