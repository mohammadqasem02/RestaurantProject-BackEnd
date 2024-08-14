using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestaurantProject.Models
{
    public class Information
    {
        [Key]
        public int RestaurantId
        {
            get; set;
        }

        [Required]
        public string RestaurantName
        {
            get; set;
        }

        [Required]
        public string RestaurantPhone
        {
            get; set;
        }

        [Required]
        public string RestaurantStreet
        {
            get; set;
        }

        // Change RestaurantNear to a collection
        public List<string> RestaurantNear { get; set; } = new List<string>();

        [Required]
        public string StartHour
        {
            get; set;
        }

        [Required]
        public string EndHour
        {
            get; set;
        }
    }
}
