using System.ComponentModel.DataAnnotations;

namespace PizzaApp.Core
{
    public class Pizza
    {
        [Key]
        public int PizzaId { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}