using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantProject.Models
{
    public class Menu
    {
        [Key]
        public int FoodId
        {
            get; set;
        }

        [Required]
        public string FoodName
        {
            get; set;
        }

        [Required]
        public decimal FoodPrice
        {
            get; set;
        }

        [Required]
        public string FoodTime
        {
            get; set;
        }

        public string FoodImg
        {
            get; set;
        }


    }
}
