using System.ComponentModel.DataAnnotations;

namespace pizza_mama.Models
{
    public class Pizza
    {
        public int PizzaID { get; set; }
        public string nom { get; set; }
        public float prix { get; set; }
        [Display(Name = "Végétarienne")]
        public bool vegetarienne { get; set; }
        public string ingredients { get; set; } 

    }
}
