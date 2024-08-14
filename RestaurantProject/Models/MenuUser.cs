using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantProject.Models
{
    public class MenuUser
    {
        [Key]
        public int Id
        {
            get; set;
        }

        [Required]
        public int FoodId
        {
            get; set;
        }
        public Boolean Morning
        {
            get; set;
        }
        public Boolean Noon
        {
            get; set;
        }
        public Boolean Evening
        {
            get; set;
        }

    }
}
